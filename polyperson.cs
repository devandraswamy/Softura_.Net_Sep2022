using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class polyperson
    {
        public void UserLogin(string Email, string Pwd)
        {
            if (Email == "sendmailtodev@gmail.com" && Pwd == "@@@dev")
            {
                Console.WriteLine("Welcome ");
                Console.WriteLine("Enter Mail ID " + Email);
                Console.WriteLine("Enter Password " + Pwd);
                Console.WriteLine("You are successfully Logged in");
            }
            else
            {
                Console.WriteLine("Enter valid Email Id and Password");
            }
        }
        public void UserLogin(int MemId, int pin)
        {
            if (MemId == 2233 && pin == 1234)
            {
                Console.WriteLine("Welcome ");
                Console.WriteLine("Enter Membership ID " + MemId);
                Console.WriteLine("Enter Pin " + pin);
                Console.WriteLine("You are successfully Logged in");
            }
            else
            {
                Console.WriteLine("Enter valid Membership Id and Pin");
            }

        }
        public void UserLogin(string number, int pin)
        {
            if (number == "7904807178" && pin == 1234)
            {
                Console.WriteLine("Welcome ");
                Console.WriteLine("Enter Mobile Number " + number);
                Console.WriteLine("Enter Pin " + pin);
                Console.WriteLine("You are successfully Logged in");
            }
            else
            {
                Console.WriteLine("Enter valid Mobile number and Pin");
            }
        }
        public static void Main()
        {
            polyperson poul = new polyperson();
            Console.WriteLine("Enter your Login choice");
            Console.WriteLine("Press 1 for EmailID and Password");
            Console.WriteLine("Press 2 for MembershipID and Pin");
            Console.WriteLine("Press 3 for Mobile Number and pin");
            int option = Convert.ToInt32(Console.ReadLine());
            string user_name = "";
            string Pswd = "";
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter Your EmailId");
                    user_name = Console.ReadLine();
                    Console.WriteLine("Enter your Password");
                    Pswd = Console.ReadLine();
                    poul.UserLogin(user_name, Pswd);
                    break;
                case 2:
                    Console.WriteLine("Enter your MembershipId");
                    user_name = Console.ReadLine();
                    Console.WriteLine("Enter your pin");
                    Pswd = Console.ReadLine();
                    poul.UserLogin(Convert.ToInt32(user_name), Convert.ToInt32(Pswd));
                    break;
                case 3:
                    Console.WriteLine("Enter your Mobile Number");
                    user_name = Console.ReadLine();
                    Console.WriteLine("Enter your Pin");
                    Pswd = Console.ReadLine();
                    poul.UserLogin(user_name, Convert.ToInt32(Pswd));
                    break;
            }


        }
    }
}