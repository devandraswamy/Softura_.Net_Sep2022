using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.IO;

namespace Framework
{
    class restaurant
    {
       public static void Main()
        {
            SortedDictionary<string, string> dic = new SortedDictionary<string, string>();
            dic.Add("chocolate shake", "chocolate cake");
            dic.Add(" specail chocolate shake", " specail chocolate cake");
            dic.Add("Kitkat Chocolate", "CHocolate bar");

            FileStream fs1 = new FileStream("C:\\Users\\dev\\Desktop\\Softura\\Hotal1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs1);
            foreach (object obj in dic)
            {
                sw.WriteLine(obj);
            }
            sw.Flush();
            sw.Close();

            FileStream fs2 = new FileStream("C:\\Users\\dev\\Desktop\\Softura\\Hotal1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs2);
            Console.WriteLine(sr.ReadToEnd());
            FileInfo fi = new FileInfo("C:\\Users\\dev\\Desktop\\Softura\\Hotal1.txt");
            Console.WriteLine(fi.FullName);
            Console.WriteLine(fi.LastAccessTime);
            Console.WriteLine(fi.CreationTime);
             long size = fi.Length;

            Console.WriteLine("the size of the File: {0}",size);

        }


    }
}
