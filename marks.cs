using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpdemo
{
    internal class Class2
    {
        public static void Main()
        {
            int[] marks = new int[5];
            int total = 0;
            for ( int i = 0; i< marks.Length; i++)
            {
                Console.WriteLine("enter the mark");
                int m = Convert.ToInt32(Console.ReadLine());
                marks[i] = m;
            }
            foreach(int i in marks)
            {
                total += i;
            }
            float per = total / marks.Length;
            Console.WriteLine("The Totl Marks Is{0}", total);
            Console.WriteLine("hence The percentag is{0}", per);
        }
    }
}
