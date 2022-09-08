using  System;
class task1{
	public static void Main(){
    Console.WriteLine("Welcome\nEnter Your Name");
    string  name=Console.ReadLine();
    Console.WriteLine("{0} Please Enter Your Name",name);
    int age=Convert.ToInt32(Console.ReadLine());
    for(int i=0; i<=age; i++)
    Console.WriteLine(name);
    }
    }
    