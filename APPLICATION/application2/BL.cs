using System;
using System.Collections.Generic;

namespace BL
{
    using DL;

    //  Person Base Class
    public abstract class Person
    {
        public string Name;
        public string Phone;

        public Person(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }

        public abstract void ShowDashboard();
    }

    //  BusRoute Class
    public class BusRoute
    {
        public string FromCity;
        public string ToCity;
        public int StandardFare;
        public int PremiumFare;

        public BusRoute(string from, string to, int standard, int premium)
        {
            FromCity = from;
            ToCity = to;
            StandardFare = standard;
            PremiumFare = premium;
        }
    }

    //  RouteManager Class
    public class RouteManager
    {
        private List<BusRoute> routes = new List<BusRoute>();

        public RouteManager()
        {
            routes.Add(new BusRoute("Lahore", "Karachi", 2500, 5000));
            routes.Add(new BusRoute("Lahore", "Islamabad", 1800, 3500));
            routes.Add(new BusRoute("Karachi", "Islamabad", 3000, 6000));
            routes.Add(new BusRoute("Lahore", "Peshawar", 2000, 4000));
            routes.Add(new BusRoute("Karachi", "Quetta", 2800, 5500));
        }

        public void ShowAllRoutes()
        {
            Console.WriteLine("  ----------------------------------------");
            Console.WriteLine("  From       | To          | Std   | Prm");
            Console.WriteLine("  ----------------------------------------");
            foreach (BusRoute route in routes)
                Console.WriteLine("  " + route.FromCity.PadRight(10) + " | " +
                    route.ToCity.PadRight(10) + " | " +
                    route.StandardFare.ToString().PadRight(5) + " | " +
                    route.PremiumFare);
        }

        public void SearchBuses(string fromCity, string toCity)
        {
            bool found = false;
            foreach (BusRoute route in routes)
            {
                if (route.FromCity.ToLower() == fromCity.ToLower() &&
                    route.ToCity.ToLower() == toCity.ToLower())
                {
                    Console.WriteLine("  Route Found: " + route.FromCity + " -> " + route.ToCity);
                    Console.WriteLine("  Standard: PKR " + route.StandardFare);
                    Console.WriteLine("  Premium : PKR " + route.PremiumFare);
                    found = true;
                }
            }
            if (!found) Console.WriteLine("  No buses found for this route.");
        }

        public int GetFare(string fromCity, string toCity, string category)
        {
            foreach (BusRoute route in routes)
            {
                if (route.FromCity.ToLower() == fromCity.ToLower() &&
                    route.ToCity.ToLower() == toCity.ToLower())
                {
                    return category == "Premium" ? route.PremiumFare : route.StandardFare;
                }
            }
            return 0;
        }
    }

    // User Class
    public class User : Person
    {
        public string Email;
        public string Password;

        private TicketDatabaseHandler ticketDatabase = new TicketDatabaseHandler();
        private RouteManager routeManager;

        public User(string name, string phone, string email, string password, RouteManager routeManager)
            : base(name, phone)
        {
            Email = email;
            Password = password;
            this.routeManager = routeManager;
        }
        public List<string[]> GetTickets()
        {
            return ticketDatabase.GetUserTickets(Phone);
        }
        public override void ShowDashboard()
        {
            Console.WriteLine("\n  Hi " + Name + "! (User Panel)");
            Console.WriteLine("  [1] Routes  [2] Search  [3] Book  [4] My Tickets  [5] Logout");
        }

        public void ViewRoutes() { routeManager.ShowAllRoutes(); }
        public void SearchBuses(string fromCity, string toCity) { routeManager.SearchBuses(fromCity, toCity); }

        public void BookRide(string fromCity, string toCity, string date, string category)
        {
            int fare = routeManager.GetFare(fromCity, toCity, category);
            if (fare == 0)
            {
                Console.WriteLine("  Route not found! Cannot book.");
                return;
            }
            string ticketID = "TK-" + new Random().Next(1000, 9999);
            ticketDatabase.AddTicket(Phone, fromCity, toCity, date, fare, ticketID, category);
            Console.WriteLine("  Booked! " + ticketID + " | " + fromCity + " -> " + toCity +
                " | " + category + " | PKR " + fare);
        }

        public void ViewTickets()
        {
            List<string[]> ticketList = ticketDatabase.GetUserTickets(Phone);
            if (ticketList.Count == 0) { Console.WriteLine("  No tickets found."); return; }
            foreach (string[] ticket in ticketList)
                Console.WriteLine("  " + ticket[5] + " | " + ticket[1] + " -> " +
                    ticket[2] + " | " + ticket[3] + " | " + ticket[6] + " | PKR " + ticket[4]);
        }
    }

    //  Admin Class
    public class Admin : Person
    {
        private UserDatabaseHandler userDatabase = new UserDatabaseHandler();
        private TicketDatabaseHandler ticketDatabase = new TicketDatabaseHandler();

        public Admin() : base("Admin", "admin") { }

        public override void ShowDashboard()
        {
            Console.WriteLine("\n  Welcome, Admin!");
            Console.WriteLine("  [1] All Users  [2] All Tickets  [3] Revenue  [4] Delete User  [5] Logout");
        }

        public void ViewAllUsers()
        {
            List<string[]> userList = userDatabase.GetAllUsers();
            if (userList.Count == 0) { Console.WriteLine("  No users found."); return; }
            Console.WriteLine("  ----------------------------------------");
            Console.WriteLine("  Name       | Phone       | Email");
            Console.WriteLine("  ----------------------------------------");
            foreach (string[] user in userList)
                Console.WriteLine("  " + user[0] + " | " + user[1] + " | " + user[2]);
            Console.WriteLine("  Total Users: " + userList.Count);
        }

        public void ViewAllTickets()
        {
            List<string[]> ticketList = ticketDatabase.GetAllTickets();
            if (ticketList.Count == 0) { Console.WriteLine("  No tickets found."); return; }
            Console.WriteLine("  ----------------------------------------");
            foreach (string[] ticket in ticketList)
                Console.WriteLine("  " + ticket[0] + " | " + ticket[1] + " -> " +
                    ticket[2] + " | " + ticket[3] + " | " + ticket[6] + " | PKR " + ticket[4] +
                    " | " + ticket[5]);
            Console.WriteLine("  Total Tickets: " + ticketList.Count);
        }

        public void ShowRevenue()
        {
            double totalSales = ticketDatabase.GetTotalFare();
            double tax = totalSales * 0.16;
            double netRevenue = totalSales - tax;
            Console.WriteLine("  Total Sales : PKR " + totalSales);
            Console.WriteLine("  Tax (16%)   : PKR " + tax.ToString("F2"));
            Console.WriteLine("  Net Revenue : PKR " + netRevenue.ToString("F2"));
        }

        public void DeleteUser(string phone)
        {
            if (userDatabase.DeleteUser(phone))
                Console.WriteLine("  User deleted successfully.");
            else
                Console.WriteLine("  User not found.");
        }
        public List<string[]> GetAllUsers()
        {
            return userDatabase.GetAllUsers();
        }

        public List<string[]> GetAllTickets()
        {
            return ticketDatabase.GetAllTickets();
        }

        public (int total, double tax, double net) GetRevenue()
        {
            int total = ticketDatabase.GetTotalFare();
            double tax = total * 0.16;
            double net = total - tax;
            return (total, tax, net);
        }
    }

    //  AuthService Class
    public class AuthService
    {
        private UserDatabaseHandler userDatabase = new UserDatabaseHandler();
        private RouteManager routeManager = new RouteManager();

        private bool IsValidPassword(string password)
        {
            if (password.Length < 8) return false;
            foreach (char character in password)
                if (char.IsDigit(character)) return true;
            return false;
        }

        private bool IsValidPhone(string phone)
        {
            if (phone.Length != 11) return false;
            foreach (char character in phone)
                if (!char.IsDigit(character)) return false;
            return true;
        }

        public (bool success, string message) SignUp(string name, string phone, string email, string password)
        {
            if (string.IsNullOrWhiteSpace(name) || name.Length < 3)
                return (false, "Name must be 3+ characters.");
            if (!IsValidPhone(phone)) return (false, "Phone must be 11 digits.");
            if (userDatabase.PhoneExists(phone)) return (false, "Phone already exists.");
            if (!IsValidPassword(password)) return (false, "Password: 8+ chars and 1 digit.");
            userDatabase.AddUser(name, phone, email, password);
            return (true, "Account created successfully!");
        }

        public (bool success, Person person) SignIn(string phone, string password)
        {
            string[] userData = userDatabase.FindUser(phone, password);
            if (userData != null)
                return (true, new User(userData[0], userData[1], userData[2], userData[3], routeManager));
            return (false, null);
        }

        public bool ResetPassword(string phone, string newPassword)
        {
            if (!IsValidPhone(phone)) return false;
            if (!IsValidPassword(newPassword)) return false;
            return userDatabase.UpdatePassword(phone, newPassword);
        }
    }
}