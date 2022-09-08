using System;
class table{
public static void Main(){
Console.WriteLine("enter the number for table you want");
int num=Convert.ToInt32(Console.ReadLine());
for(int i=0 ;i<=20;i++)
Console.WriteLine("{0} X {1} = {2}",num,i,num*i);
}
}
