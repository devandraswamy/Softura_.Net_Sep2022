
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace abstractclass1
{
    class sql
    {
        public void getdata()
        {
            SqlConnection con = new SqlConnection("Data source=DESKTOP-6FC80GU\\SQLEXPRESS;  database=test1; user id=sa; password=p@ssword");
            con.Open();
            SqlCommand com = new SqlCommand("select * from task", con);
            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader[0].ToString()+"\t"+ reader[1].ToString()+ "\t" + reader[2].ToString());
            }
            con.Close();
        }

        public void insData (string fname, string lname,string city)
        {
            SqlConnection con = new SqlConnection("Data source=DESKTOP-6FC80GU\\SQLEXPRESS;  database=test1; user id=sa; password=p@ssword");
            SqlCommand cmd1 = new SqlCommand("sp_task", con);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@fname", SqlDbType.NVarChar).Value = fname;
            cmd1.Parameters.AddWithValue("@lname", SqlDbType.NVarChar).Value = lname; 
            cmd1.Parameters.AddWithValue("@city", SqlDbType.NVarChar).Value = city;
            con.Open();
            cmd1.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("Inserted");





        }


        public static void Main()
        {
            sql s = new sql();
           
            s.insData("dev", "Mass", "dubai");
            s.insData("Jaya", "kanthan", "chennai");
            s.getdata();

        }
    }
}
