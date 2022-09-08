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
			string[][] arr=new string[3][];
			arr[0]=new string[]{"oreo","marygold","bourbun","nutrichoise"	};
			arr[1]=new string[]{"diarymilk","5strat","munch","perk","milkybar"};
			arr[2]=new string[]{"Margarita","Margarita","Negroni","Moscow","Martini","Mojito"};
			
			for(int i=0; i<arr.Length; i++){
			  for(int j=0;j<arr[i].Length; j++){
			    Console.Write(arr[i][j]+" ");
			  }
			  Console.WriteLine();
			}
			
	}
}
}