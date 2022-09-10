using System;
using System.Collections.Generic;
using System.Text;

namespace abstractclass1
{
    abstract class accom
    {
        public abstract void membership();
       
    }

    class silver:accom
    {
        public override void membership()
        {
            Console.WriteLine("Silver Package\n 3 days of accomdation");
           
        }
    }

    class gold:accom
    {
        public override void membership()
        {
            Console.WriteLine("gold package\n 5 days accodation at resort and \n 5 dinners on the house");

        }
    }

    class platinum:accom
    {
        public override void membership()
        {
            Console.WriteLine("Platinum package\n 7 days Of accomdtion at resort\n 5 dinners on the house");

        }
    }
    class resort
    {
        public static void Main()
        {
            silver s1 = new silver();
            gold s2 = new gold();
            platinum s3 = new platinum();
            s1.membership();
            s2.membership();
            s3.membership();
        }
    }
}
