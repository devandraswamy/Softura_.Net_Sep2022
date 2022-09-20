using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace abstractclass1
{
    internal class HotalDiish
    {
        public static void Main()
        {
            List<string> li = new List<string>();
            li.Add("Idly");
            li.Add("Chapathi");
            li.Add("Masal Dosai");
            li.Add("Parata");
            li.Add("Pongal");

            FileStream fst = new FileStream("C:\\Users\\dev\\Desktop\\Softura\\NewSample.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fst);
            sw.BaseStream.Seek(0, SeekOrigin.End);
            foreach (string i in li)
                sw.WriteLine(i);
            sw.Flush();
            fst.Close();

            FileStream fst1 = new FileStream("C:\\Users\\dev\\Desktop\\Softura\\NewSample.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fst1);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            Console.WriteLine(sr.ReadToEnd());
            sr.Close();
            fst1.Close();

            //FileInfo fio = new FileInfo("C:\\Users\\dev\\Desktop\\Softura\\NewSample.txt");
            //Console.WriteLine("File Creation Time : " + fio.CreationTime);
            //Console.WriteLine("Length of file: " + fio.Length);



        }
    }
}