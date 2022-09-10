using System;
using System.Collections.Generic;
using System.Text;

namespace task3
{
    class div1
    {
        public int a, b;
        public void sum()
        {
            Console.WriteLine("enter the number to  be added");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hence The Answer Of sum Is   {0} " , a + b);
        }
            public void sub()
            {
                Console.WriteLine("enter the number to  be subtract");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Hence The Answer Of sum Is:  {0}", a - b);
            }
    }

    class div2:div1
    {
        public void multi()
        {
            Console.WriteLine("enter the number to  be Multiply  ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hence The Answer Of sum Is:  {0}", a*b);

        }
        public void div()
        {
            Console.WriteLine("enter the number to  be divided:  ");
             a = Convert.ToInt32(Console.ReadLine());
             b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hence The Answer Of sum Is : {0}  ", a / b);

        }
    }
    class calculation
    {
        public static void Main()
        {
            //div1 obj1 = new div1();
            div2 obj2 = new div2();
            obj2.sum();
            obj2.sub();
            obj2.multi();
            obj2.div();




        }
    }
}
