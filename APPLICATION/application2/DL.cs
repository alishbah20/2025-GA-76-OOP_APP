
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DL
{
    public class DatabaseHandler
    {
        private string connectionString = "Server=localhost;Database=BusBookingDB;Uid=root;Pwd=alishbah01;";

        protected MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }

    public class UserDatabaseHandler : DatabaseHandler
    {
        public bool PhoneExists(string phone)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Phone = '" + phone + "'";
            MySqlConnection connection = GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            connection.Open();
            int count = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();
            return count > 0;
        }

        public string[] FindUser(string phone, string password)
        {
            string query = "SELECT * FROM Users WHERE Phone = '" + phone + "' AND Password = '" + password + "'";
            MySqlConnection connection = GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                string[] userData = new string[4];
                userData[0] = reader["Name"].ToString();
                userData[1] = reader["Phone"].ToString();
                userData[2] = reader["Email"].ToString();
                userData[3] = reader["Password"].ToString();
                connection.Close();
                return userData;
            }
            connection.Close();
            return null;
        }

        public void AddUser(string name, string phone, string email, string password)
        {
            string query = "INSERT INTO Users (Name, Phone, Email, Password) VALUES ('" + name + "','" + phone + "','" + email + "','" + password + "')";
            MySqlConnection connection = GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public bool UpdatePassword(string phone, string newPassword)
        {
            string query = "UPDATE Users SET Password = '" + newPassword + "' WHERE Phone = '" + phone + "'";
            MySqlConnection connection = GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            connection.Open();
            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowsAffected > 0;
        }

        public bool DeleteUser(string phone)
        {
            string query = "DELETE FROM Users WHERE Phone = '" + phone + "'";
            MySqlConnection connection = GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            connection.Open();
            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowsAffected > 0;
        }

        public List<string[]> GetAllUsers()
        {
            List<string[]> userList = new List<string[]>();
            string query = "SELECT Name, Phone, Email FROM Users";
            MySqlConnection connection = GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string[] userData = new string[3];
                userData[0] = reader["Name"].ToString();
                userData[1] = reader["Phone"].ToString();
                userData[2] = reader["Email"].ToString();
                userList.Add(userData);
            }
            connection.Close();
            return userList;
        }
    }

    public class TicketDatabaseHandler : DatabaseHandler
    {
        public void AddTicket(string phone, string fromCity, string toCity, string date, int fare, string ticketID, string category)
        {
            string query = "INSERT INTO Tickets (Phone, FromCity, ToCity, Date, Fare, TicketID, Category) VALUES ('" + phone + "','" + fromCity + "','" + toCity + "','" + date + "'," + fare + ",'" + ticketID + "','" + category + "')";
            MySqlConnection connection = GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public List<string[]> GetUserTickets(string phone)
        {
            List<string[]> ticketList = new List<string[]>();
            string query = "SELECT * FROM Tickets WHERE Phone = '" + phone + "'";
            MySqlConnection connection = GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string[] ticket = new string[7];
                ticket[0] = reader["Phone"].ToString();
                ticket[1] = reader["FromCity"].ToString();
                ticket[2] = reader["ToCity"].ToString();
                ticket[3] = reader["Date"].ToString();
                ticket[4] = reader["Fare"].ToString();
                ticket[5] = reader["TicketID"].ToString();
                ticket[6] = reader["Category"].ToString();
                ticketList.Add(ticket);
            }
            connection.Close();
            return ticketList;
        }

        public List<string[]> GetAllTickets()
        {
            List<string[]> ticketList = new List<string[]>();
            string query = "SELECT * FROM Tickets";
            MySqlConnection connection = GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            connection.Open();
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string[] ticket = new string[7];
                ticket[0] = reader["Phone"].ToString();
                ticket[1] = reader["FromCity"].ToString();
                ticket[2] = reader["ToCity"].ToString();
                ticket[3] = reader["Date"].ToString();
                ticket[4] = reader["Fare"].ToString();
                ticket[5] = reader["TicketID"].ToString();
                ticket[6] = reader["Category"].ToString();
                ticketList.Add(ticket);
            }
            connection.Close();
            return ticketList;
        }

        public int GetTotalFare()
        {
            int totalFare = 0;
            string query = "SELECT SUM(Fare) FROM Tickets";
            MySqlConnection connection = GetConnection();
            MySqlCommand command = new MySqlCommand(query, connection);
            connection.Open();
            object result = command.ExecuteScalar();
            if (result != DBNull.Value)
                totalFare = Convert.ToInt32(result);
            connection.Close();
            return totalFare;
        }
    }
}