using Microsoft.Data.Sqlite;
using System.Security.Cryptography;
using System.Text;
using System.Transactions;

namespace TBS_CS
{
    internal class SQL
    {

        ///<summary>
        ///Create the database tables. 
        ///Will always run on start
        ///</summary>
        public static void CreateTables()
        {
            using (SqliteConnection connection = new SqliteConnection("Data Source=database.db"))
            {
                connection.Open();
                SqliteCommand usersTable = connection.CreateCommand();
                usersTable.CommandText = @"
                        CREATE TABLE IF NOT EXISTS users (
                        userId integer PRIMARY KEY,
                        username text UNIQUE NOT NULL,
                        password text NOT NULL,
                        name text NOT NULL,
                        phoneNum text NOT NULL,
                        userType text NOT NULL";

                SqliteCommand carsTable = connection.CreateCommand();
                carsTable.CommandText = @"
                        CREATE TABLE IF NOT EXISTS cars (
                        carId integer PRIMARY KEY,
                        licenseNumber integer NOT NULL";

                SqliteCommand tripsTable = connection.CreateCommand();
                tripsTable.CommandText = @"
                        CREATE TABLE IF NOT EXISTS trips (
                        tripId integer PRIMARY KEY,
                        pickupAdd text NOT NULL,
                        dropoffAdd text NOT NULL,
                        pickupTime text NOT NULL,
                        customerID integer NOT NULL,
                        driverID integer,
                        carID integer,
                        FOREIGN KEY (customerID) REFERENCES customers(userId),
                        FOREIGN KEY (driverID) REFERENCES drivers(userID),
                        FOREIGN KEY (carID) REFERENCES cars(carID)
                    );";

                using (TransactionScope transaction = new())
                {
                    // Create tables, make sure all commands succeeded
                    usersTable.ExecuteNonQuery();
                    carsTable.ExecuteNonQuery();
                    tripsTable.ExecuteNonQuery();
                    transaction.Complete();
                }
                connection.Close();
            }
            return;
        }

        ///<summary>
        ///Create a new user. 
        ///<returns>Returns 1 if unsuccessful, 0 if successful</returns>
        ///</summary>
        public static int CreateUser(string username, string password, string name, string phoneNumber, string userType)
        {
            // Turn password into hash
            string passHash = Convert.ToBase64String(SHA256.HashData(Encoding.UTF8.GetBytes(password)));

            using (SqliteConnection connection = new SqliteConnection("Data Source=database.db"))
            {
                connection.Open();
                SqliteCommand checkUser = connection.CreateCommand();
                // Check if username is already in use
                checkUser.CommandText = @"SELECT username FROM users WHERE username = @user";
                checkUser.Parameters.AddWithValue("@user", username);
                SqliteDataReader reader = checkUser.ExecuteReader();
                while (reader.Read())
                {
                    // If user with username exists, exit and return 1
                    connection.Close();
                    return 1;
                }
                // Otherwise, make user
                SqliteCommand makeUser = connection.CreateCommand();
                makeUser.CommandText = @"INSERT INTO users (username, password, name, phoneNum, userType) VALUES (@user, @pass, @name, @phone, @type)";
                makeUser.Parameters.AddWithValue("@user", username);
                makeUser.Parameters.AddWithValue("@pass", passHash);
                makeUser.Parameters.AddWithValue("@name", name);
                makeUser.Parameters.AddWithValue("@phone", phoneNumber);
                makeUser.Parameters.AddWithValue("@type", userType);
                using (TransactionScope transaction = new())
                {
                    makeUser.ExecuteNonQuery();
                    transaction.Complete();
                }
                connection.Close();
            }
            return 0;
        }

        ///<summary>
        ///Get an existing user. 
        ///<returns>Returns "fail" if unsuccessful, and the user data array if successful [Username, Name] </returns>
        ///</summary>
        public static string[] GetUser(string username, string password)
        {
            // Turn password into hash
            string passHash = Convert.ToBase64String(SHA256.HashData(Encoding.UTF8.GetBytes(password)));
            using (SqliteConnection connection = new SqliteConnection("Data Source=database.db"))
            {
                connection.Open();
                SqliteCommand findUser = connection.CreateCommand();
                findUser.CommandText = @"SELECT username FROM users WHERE username = @user";
                findUser.Parameters.AddWithValue("@user", username);
                SqliteDataReader reader = findUser.ExecuteReader();
                // If reader.Read = false, meaning no rows found:
                if (!reader.Read())
                {
                    connection.Close();
                    return ["fail"];
                }
                // Otherwise, get the row and check passwords
                // Starts at 0 for ID
                while (reader.Read())
                {
                    if (passHash != reader.GetString(2))
                    {
                        // Passwords do not match
                        connection.Close();
                        return ["fail"];
                    }
                    else
                    {
                        // Passwords match, return user data array
                        connection.Close();
                        return [reader.GetString(1), reader.GetString(3)];
                    }
                }
            }
            return [""];
        }

        ///<summary>
        ///Create a new trip. 
        ///<returns>Returns 1 if unsuccessful, and 0 if successful.</returns>
        ///</summary>
        public static int CreateTrip(string pickupAddress, string dropoffAddress, string pickupTime, int customerId)
        {
            using (SqliteConnection connection = new SqliteConnection("Data Source=database.db"))
            {
                connection.Open();
                SqliteCommand createTrip = connection.CreateCommand();
                createTrip.CommandText = @"INSERT INTO users (pickupAdd, dropoffAdd, pickupTime, customerId) VALUES (@pickup, @dropoff, @time, @cust)";
                createTrip.Parameters.AddWithValue("@pickup", pickupAddress);
                createTrip.Parameters.AddWithValue("@dropoff", dropoffAddress);
                createTrip.Parameters.AddWithValue("@time", pickupTime);
                createTrip.Parameters.AddWithValue("@cust", customerId);

                using (TransactionScope transaction = new())
                {
                    createTrip.ExecuteNonQuery();
                    transaction.Complete();
                }
                connection.Close();
            }
            return 0;
        }

        ///<summary>
        ///Add a driver to a trip, using the trip and drivers' IDs. 
        ///<returns>Returns 1 if unsuccessful, and 0 if successful. </returns>
        ///</summary>
        public static int AddDriverToTrip(int tripId, int driverId)
        {
            using (SqliteConnection connection = new SqliteConnection("Data Source=database.db"))
            {
                connection.Open();
                SqliteCommand addDriver = connection.CreateCommand();
                addDriver.CommandText = @"UPDATE trips SET driverId = @driver WHERE tripId = @trip";
                addDriver.Parameters.AddWithValue("@driver", driverId);
                addDriver.Parameters.AddWithValue("@trip", tripId);

                using (TransactionScope transaction = new())
                {
                    addDriver.ExecuteNonQuery();
                    transaction.Complete();
                }
                connection.Close();
            }
            return 0;
        }

        /* TODO: 
         * Get User Data
         * Add Cars
         * Delete Cars
         * Get Unassigned Trips for Driver
         * Get Assigned Trips for Driver
         * Get Trips for User
        */
    }
}
