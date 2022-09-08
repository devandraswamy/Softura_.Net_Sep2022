using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
		public static void Main(string[] args)
		{
		Console.WriteLine("Do You Have Travel Histroy\n Yes Or No");
		string reply=Console.ReadLine();
		
		if (reply=="yes")
		{
		 Console.WriteLine("Do You Have Temprature");
		string reply2=Console.ReadLine();
		
		  if(reply2=="yes"){
		    
		    Console.WriteLine("Do You Have Cough or snees");
		    string reply3=Console.ReadLine();
		     if(reply3=="yes"){
		    Console.WriteLine("go For Swap Test");
		  }
		  else{
		    Console.WriteLine("Quarantine Fever Medication");
		  }
		  }
		 
		  else{
		    Console.WriteLine("Home Quarantine for about 28");
		  }
		}
		else
		{
		  Console.WriteLine("Safe You Dont Have Covid");
		}
		
		}
	}
}