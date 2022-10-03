using Mvctask.Controllers;

namespace Mvctask.Models
{
    public class Empdata
    {
        public int EmpId { get; set; }
        public string FirstName { get; set; }
        public string lastName { get; set; }

        public string gender { get; set; }


        public static List<Empdata> Getallempdata()
        {
            List<Empdata> edata = new()
            {
                new Empdata(){EmpId=1,FirstName="devandra",lastName="swamy",gender="male"},
                new Empdata(){EmpId=2,FirstName="samual",lastName="rajandran",gender="male"},
                new Empdata(){EmpId=3,FirstName="siva",lastName="priya",gender="Female"},
                new Empdata(){EmpId=4,FirstName="swathi",lastName="priya",gender="Female"},
                new Empdata(){EmpId=5,FirstName="Ajay",lastName="Reyan",gender="male"},
                new Empdata(){EmpId=6,FirstName="jay",lastName="kishan",gender="male"}
            };
            return edata;
        }

        public static List<Empdata> getsingle()
        {
            List<Empdata> es = new()
            {
                new Empdata() {EmpId=10,FirstName="sinle",lastName="emp",gender="male"}
               
            };
            return es;
        }
    }
}
