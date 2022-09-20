using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Sales
    {
        public virtual void TotalSalary(double salary)
        {
            double BonusCalc, netTotalSalary;
            BonusCalc = (salary * 20) / 100;
           netTotalSalary = BonusCalc + salary;
            Console.WriteLine("Salary with Bonus:" + netTotalSalary);
        }
    }
    class Production : Sales
    {
        public override void TotalSalary(double salary)
        {
            double Bonus, netTotalSalary;
            Bonus = (salary * 10) / 100;
            netTotalSalary = Bonus + salary;
            Console.WriteLine("Salary with Bonus:" + netTotalSalary);
        }
    }
    internal class salary
    {



        public static void Main()
        {
            Console.WriteLine("Enter the Employee ID: ");
            int eId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Employee Name: ");
            string empName = Console.ReadLine();
            Console.WriteLine("Enter the Employee Gender: ");
            string empGender = Console.ReadLine();
            Console.WriteLine("Enter the Employee's Year of Experience:");
            int empexpe = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Employee Salary");
            double empsalary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Employee's Department(sales/production)");
            string empDepart = Console.ReadLine();

            Console.WriteLine("Employee Details:");

            Console.WriteLine("Id:" + eId);
            Console.WriteLine("Name:" + empName);
            Console.WriteLine("Gender:" + empGender);
            Console.WriteLine("Year of Experence:" + empexpe);
            Console.WriteLine("Department:" + empDepart);

            if (empDepart == "sales")
            {
                Sales salobj = new Sales();
                salobj.TotalSalary(empsalary);
            }
            else if (empDepart == "production")
            {
                Production prodobj = new Production();
                prodobj.TotalSalary(empsalary);
            }
            else
            {
                Console.WriteLine("Enter the valid Department");
            }


        }



    }
}