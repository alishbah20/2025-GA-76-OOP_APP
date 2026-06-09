
using System;
using System.Collections.Generic;
using System.IO;

namespace UI
{

    using BL;

    class Program
    {
        static AuthService authService = new AuthService();

        static void Main(string[] args)
        {
            bool isRunning = true;

            while (isRunning)
            {
                ConsoleHelper.DrawHeader("BUS BOOKING SYSTEM");
                Console.WriteLine("  [1] User Sign Up");
                Console.WriteLine("  [2] User Sign In");
                Console.WriteLine("  [3] Reset Password");
                Console.WriteLine("  [4] Fare List");
                Console.WriteLine("  [5] Admin Login");
                Console.WriteLine("  [6] Exit");
                Console.Write("\n  Choice: ");
                string choice = Console.ReadLine();

                if (choice == "1") SignUp();
                else if (choice == "2") SignIn();
                else if (choice == "3") ResetPassword();
                else if (choice == "4") ShowFares();
                else if (choice == "5") AdminLogin();
                else if (choice == "6") isRunning = false;
                else
                {
                    Console.WriteLine("  Invalid choice!");
                    ConsoleHelper.Pause();
                }
            }
        }

        //  User Sign Up 
        static void SignUp()
        {
            ConsoleHelper.DrawHeader("USER SIGN UP");
            Console.Write("  Full Name : "); string name = Console.ReadLine();
            Console.Write("  Phone     : "); string phone = Console.ReadLine();
            Console.Write("  Email     : "); string email = Console.ReadLine();
            Console.Write("  Password  : "); string password = Console.ReadLine();

            (bool success, string message) result = authService.SignUp(name, phone, email, password);
            Console.WriteLine("\n  " + result.message);
            ConsoleHelper.Pause();
        }

        //User Sign In 
        static void SignIn()
        {
            ConsoleHelper.DrawHeader("USER SIGN IN");
            Console.Write("  Phone    : "); string phone = Console.ReadLine();
            Console.Write("  Password : "); string password = Console.ReadLine();

            (bool success, Person person) result = authService.SignIn(phone, password);

            if (!result.success)
            {
                Console.WriteLine("\n  Login failed. Wrong phone or password.");
                ConsoleHelper.Pause();
                return;
            }

            UserMenu((User)result.person);
        }

        //  Reset Password
        static void ResetPassword()
        {
            ConsoleHelper.DrawHeader("RESET PASSWORD");
            Console.Write("  Phone        : "); string phone = Console.ReadLine();
            Console.Write("  New Password : "); string newPassword = Console.ReadLine();

            bool isSuccess = authService.ResetPassword(phone, newPassword);
            Console.WriteLine(isSuccess ? "\n  Password reset successfully!" : "\n  Reset failed. Check phone number.");
            ConsoleHelper.Pause();
        }

        // Admin Login 
        static void AdminLogin()
        {
            ConsoleHelper.DrawHeader("ADMIN LOGIN");
            Console.Write("  Password : "); string adminPassword = Console.ReadLine();

            if (adminPassword == "admin123")
            {
                Admin admin = new Admin();
                AdminMenu(admin);
            }
            else
            {
                Console.WriteLine("\n  Wrong password! Access denied.");
                ConsoleHelper.Pause();
            }
        }

        //  Admin Menu 
        static void AdminMenu(Admin admin)
        {
            bool isActive = true;

            while (isActive)
            {
                ConsoleHelper.DrawHeader("ADMIN PANEL");
                admin.ShowDashboard();
                Console.Write("\n  Choice: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    ConsoleHelper.DrawHeader("ALL USERS");
                    admin.ViewAllUsers();
                    ConsoleHelper.Pause();
                }
                else if (choice == "2")
                {
                    ConsoleHelper.DrawHeader("ALL TICKETS");
                    admin.ViewAllTickets();
                    ConsoleHelper.Pause();
                }
                else if (choice == "3")
                {
                    ConsoleHelper.DrawHeader("REVENUE REPORT");
                    admin.ShowRevenue();
                    ConsoleHelper.Pause();
                }
                else if (choice == "4")
                {
                    ConsoleHelper.DrawHeader("DELETE USER");
                    Console.Write("  Enter Phone to Delete: ");
                    string phoneToDelete = Console.ReadLine();
                    admin.DeleteUser(phoneToDelete);
                    ConsoleHelper.Pause();
                }
                else if (choice == "5")
                {
                    isActive = false;
                }
                else
                {
                    Console.WriteLine("  Invalid choice!");
                    ConsoleHelper.Pause();
                }
            }
        }

        // User Menu 
        static void UserMenu(User user)
        {
            bool isActive = true;

            while (isActive)
            {
                ConsoleHelper.DrawHeader("USER DASHBOARD");
                user.ShowDashboard();
                Console.Write("\n  Choice: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    ConsoleHelper.DrawHeader("AVAILABLE ROUTES");
                    user.ViewRoutes();
                    ConsoleHelper.Pause();
                }
                else if (choice == "2")
                {
                    ConsoleHelper.DrawHeader("SEARCH BUSES");
                    Console.Write("  From City : "); string fromCity = Console.ReadLine();
                    Console.Write("  To City   : "); string toCity = Console.ReadLine();
                    user.SearchBuses(fromCity, toCity);
                    ConsoleHelper.Pause();
                }
                else if (choice == "3")
                {
                    ConsoleHelper.DrawHeader("BOOK RIDE");
                    Console.Write("  From City : "); string fromCity = Console.ReadLine();
                    Console.Write("  To City   : "); string toCity = Console.ReadLine();
                    Console.Write("  Date      : "); string date = Console.ReadLine();
                    Console.WriteLine("  [1] Standard  [2] Premium");
                    Console.Write("  Category  : ");
                    string categoryChoice = Console.ReadLine();
                    string category = categoryChoice == "2" ? "Premium" : "Standard";
                    user.BookRide(fromCity, toCity, date, category);
                    ConsoleHelper.Pause();
                }
                else if (choice == "4")
                {
                    ConsoleHelper.DrawHeader("MY TICKETS");
                    user.ViewTickets();
                    ConsoleHelper.Pause();
                }
                else if (choice == "5")
                {
                    isActive = false;
                }
                else
                {
                    Console.WriteLine("  Invalid choice!");
                    ConsoleHelper.Pause();
                }
            }
        }


        // Fare List
        static void ShowFares()
        {
            ConsoleHelper.DrawHeader("FARE LIST");
            Console.WriteLine("  Standard : PKR 1800 - 5000");
            Console.WriteLine("  Premium  : PKR 3500 - 8000");
            ConsoleHelper.Pause();
        }
    }
}