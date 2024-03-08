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
        ///Will always run on start, if it doesn't exist
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
                        userType text NOT NULL
                        );";

                SqliteCommand carsTable = connection.CreateCommand();
                carsTable.CommandText = @"
                        CREATE TABLE IF NOT EXISTS cars (
                        carId integer PRIMARY KEY,
                        licenseNumber integer NOT NULL,
                        carType text NOT NULL
                        );";

                SqliteCommand tripsTable = connection.CreateCommand();
                tripsTable.CommandText = @"
                        CREATE TABLE IF NOT EXISTS trips (
                        tripId integer PRIMARY KEY,
                        pickupAdd text NOT NULL,
                        dropoffAdd text NOT NULL,
                        pickupTime text NOT NULL,
                        carType text NOT NULL,
                        customerID integer NOT NULL,
                        driverID integer,
                        carID integer,
                        FOREIGN KEY (customerID) REFERENCES users(userId),
                        FOREIGN KEY (driverID) REFERENCES users(userID),
                        FOREIGN KEY (carID) REFERENCES cars(carID)
                        );";

                usersTable.ExecuteNonQuery();
                carsTable.ExecuteNonQuery();
                tripsTable.ExecuteNonQuery();
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
                checkUser.CommandText = @"SELECT username FROM users WHERE username = @user;";
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
                makeUser.CommandText = @"INSERT INTO users (username, password, name, phoneNum, userType) VALUES (@user, @pass, @name, @phone, @type);";
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
        ///<returns>Returns "fail" if unsuccessful, and the user data array if successful [Username, Name, UserType] </returns>
        ///</summary>
        public static string[] GetUser(string username, string password)
        {
            // Turn password into hash
            string passHash = Convert.ToBase64String(SHA256.HashData(Encoding.UTF8.GetBytes(password)));
            using (SqliteConnection connection = new SqliteConnection("Data Source=database.db"))
            {
                connection.Open();
                SqliteCommand findUser = connection.CreateCommand();
                findUser.CommandText = @"SELECT * FROM users WHERE username = @user;";
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
                if (passHash != reader.GetString(2))
                {
                    // Passwords do not match
                    connection.Close();
                    return ["fail"];
                }
                else
                {
                    // Passwords match, return user data array
                    string[] toReturn = [reader.GetInt32(0).ToString(), reader.GetString(1), reader.GetString(3), reader.GetString(5)];
                    connection.Close();
                    return toReturn;
                }
            }
        }

        ///<summary>
        ///Create a new trip. 
        ///</summary>
        public static void CreateTrip(string pickupAddress, string dropoffAddress, string pickupTime, int customerId)
        {
            using (SqliteConnection connection = new SqliteConnection("Data Source=database.db"))
            {
                connection.Open();
                SqliteCommand createTrip = connection.CreateCommand();
                createTrip.CommandText = @"INSERT INTO users (pickupAdd, dropoffAdd, pickupTime, customerId) VALUES (@pickup, @dropoff, @time, @cust);";
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
            return;
        }

        ///<summary>
        ///Add a driver to a trip, using the trip and drivers' IDs. 
        ///</summary>
        public static void AddDriverToTrip(int tripId, int driverId)
        {
            using (SqliteConnection connection = new SqliteConnection("Data Source=database.db"))
            {
                connection.Open();
                SqliteCommand addDriver = connection.CreateCommand();
                addDriver.CommandText = @"UPDATE trips SET driverId = @driver WHERE tripId = @trip;";
                addDriver.Parameters.AddWithValue("@driver", driverId);
                addDriver.Parameters.AddWithValue("@trip", tripId);

                using (TransactionScope transaction = new())
                {
                    addDriver.ExecuteNonQuery();
                    transaction.Complete();
                }
                connection.Close();
            }
            return;
        }

        ///<summary>
        ///Add a new car
        ///</summary>
        public static void AddCar(string license)
        {
            using (SqliteConnection connection = new SqliteConnection("Data Source=database.db"))
            {
                connection.Open();
                SqliteCommand addCar = connection.CreateCommand();
                addCar.CommandText = @"INSERT INTO cars (licenseNumber) VALUES (@license);";
                addCar.Parameters.AddWithValue("@license", license);

                using (TransactionScope transaction = new())
                {
                    addCar.ExecuteNonQuery();
                    transaction.Complete();
                }
                connection.Close();
            }
            return;
        }

        ///<summary>
        ///Deletes a car, using its license number
        ///</summary>
        public static void DeleteCar(string license)
        {
            using (SqliteConnection connection = new SqliteConnection("Data Source=database.db"))
            {
                connection.Open();
                SqliteCommand deleteCar = connection.CreateCommand();
                deleteCar.CommandText = @"DELETE FROM cars WHERE licenseNumber = (@license);";
                deleteCar.Parameters.AddWithValue("@license", license);

                using (TransactionScope transaction = new())
                {
                    deleteCar.ExecuteNonQuery();
                    transaction.Complete();
                }
                connection.Close();
            }
            return;
        }

        public static List<string> GetUnassignedTrips()
        {
            using (SqliteConnection connection = new SqliteConnection("Data Source=database.db"))
            {
                connection.Open();
                List<string> toReturn = new();
                SqliteCommand GetTrips = connection.CreateCommand();
                GetTrips.CommandText = @"SELECT * FROM trips WHERE driverID IS NULL;";
                using (TransactionScope transaction = new())
                {
                    SqliteDataReader reader = GetTrips.ExecuteReader();
                    while (reader.Read()) 
                    {
                        StringBuilder stringBuilder = new StringBuilder();
                        stringBuilder.Append(reader.GetString(1));
                        stringBuilder.Append(", ");
                        stringBuilder.Append(reader.GetString(2));
                        stringBuilder.Append(", ");
                        stringBuilder.Append(reader.GetString(3));
                        toReturn.Add(stringBuilder.ToString());
                    }
                    transaction.Complete();
                }
                connection.Close();
                return toReturn;
            }
        }

        public static List<string> GetAssignedTrips(int driverId)
        {
            using (SqliteConnection connection = new SqliteConnection("Data Source=database.db"))
            {
                connection.Open();
                List<string> toReturn = new();
                SqliteCommand GetTrips = connection.CreateCommand();
                GetTrips.CommandText = @"SELECT * FROM trips WHERE driverID = @driver;";
                GetTrips.Parameters.AddWithValue("@driver", driverId);
                using (TransactionScope transaction = new())
                {
                    SqliteDataReader reader = GetTrips.ExecuteReader();
                    while (reader.Read())
                    {
                        StringBuilder stringBuilder = new StringBuilder();
                        stringBuilder.Append(reader.GetString(1));
                        stringBuilder.Append(", ");
                        stringBuilder.Append(reader.GetString(2));
                        stringBuilder.Append(", ");
                        stringBuilder.Append(reader.GetString(3));
                        toReturn.Add(stringBuilder.ToString());
                    }
                    transaction.Complete();
                }
                connection.Close();
                return toReturn;
            }
        }

        public static List<string> GetUserTrips(int userId)
        {
            using (SqliteConnection connection = new SqliteConnection("Data Source=database.db"))
            {
                connection.Open();
                List<string> toReturn = new();
                SqliteCommand GetTrips = connection.CreateCommand();
                GetTrips.CommandText = @"SELECT * FROM trips WHERE customerID = @user;";
                GetTrips.Parameters.AddWithValue("@user", userId);
                using (TransactionScope transaction = new())
                {
                    SqliteDataReader reader = GetTrips.ExecuteReader();
                    while (reader.Read())
                    {
                        StringBuilder stringBuilder = new StringBuilder();
                        stringBuilder.Append(reader.GetString(1));
                        stringBuilder.Append(", ");
                        stringBuilder.Append(reader.GetString(2));
                        stringBuilder.Append(", ");
                        stringBuilder.Append(reader.GetString(3));
                        toReturn.Add(stringBuilder.ToString());
                    }
                    transaction.Complete();
                }
                connection.Close();
                return toReturn;
            }
        }
    }
}
