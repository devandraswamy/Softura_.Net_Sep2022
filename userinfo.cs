using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace abstractclass1
{
    public class Employee
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }
    }

    internal class userinfo
    {
        public static void Main()
        {

            Employee emp = new Employee()
            {
                ID = 1122,
                Name = "Devandraswamy",
                Age = 21,
                Gender = "male"
            };
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Employee));
            using (StreamWriter stream = new StreamWriter("employeeTask.xml"))
            {
                xmlSerializer.Serialize(stream, emp);
            }
            Console.WriteLine("the Name={0},age={1},Id={2},Gender={3}", emp.Name, emp.Age, emp.ID, emp.Gender);

        }
    }
}