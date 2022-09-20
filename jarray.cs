using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractclass1
{
    internal class jarray
    {
        public static void Main()
        {
            string[][] patients = new string[3][];
            patients[0] = new string[] { "Jay", "Kay", "Ray", "May" };
            patients[1] = new string[] { "Tommy", "Jonny" };
            patients[2] = new string[] { "Sita", "Lakshmi", "Riya", "Priya", "Ram" };
            for (int i = 0; i < patients.Length; i++)
            {
                for (int j = 0; j < patients[i].Length; j++)
                {
                    Console.Write(patients[i][j] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}