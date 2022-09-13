using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class nage
    {
        class Name
        {
            public string name1  { get; set; }
            public void name(string name1)
            {
                Console.WriteLine("hello Mr. {0} Welcome", name1);
            }

        }
        class Age:Name
        {
            public void age(int a)
            {
                Console.WriteLine("You Age iS{0}", a);
            }

        }

        public static void Main()
        {
            Age name = new Age();
            Console.WriteLine("Enter Your Nmae");
            name.name1 = Console.ReadLine();
            //Age n1 = new Age();
            //n1.name("dev");
           
            Console.WriteLine("kindly enter Your Age");
            int a1 = Convert.ToInt32(Console.ReadLine());
            name.age(a1);
            
        }
    }
}
