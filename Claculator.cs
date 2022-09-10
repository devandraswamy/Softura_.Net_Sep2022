using System;
using System.Collections.Generic;
using System.Text;

namespace abstractclass1
{
    class calc : addition, subtraction, multiply, division
    {

        int n1, n2;
        public void add()
        {
            Console.WriteLine("Enter  he Value To Add");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("hence The Sum Value Is:  {0}",n1+n2);
        }
        public void sub()
        {
            Console.WriteLine("Enter  he Value To sub");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("hence The Sum Value Is:  {0}", n1-n2);

        }
        public void mul()
        {
            Console.WriteLine("Enter  he Value To multiply");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("hence The Sum Value Is:  {0}", n1 * n2);

        }
        public void div()
        {
            Console.WriteLine("Enter  he Value To div");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("hence The Sum Value Is: {0}", n1 / n2);

        }

    }
    class Claculator
    {
       public static void Main()
        {
            calc obj1 = new calc();
            obj1.add();
            obj1.sub();
            obj1.mul();
            obj1.div();
        }
    }
}
