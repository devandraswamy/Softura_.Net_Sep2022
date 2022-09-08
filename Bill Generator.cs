using System;
class bill{
  public static void Main(){
    Console.WriteLine("Enter The Amount Consumed");
    int unit= Convert.ToInt32(Console.ReadLine());
    if(unit<=200){
      Console.WriteLine("Consumed Units {0} \n you need to pay {1}",unit,unit*2);
    }
    else if(unit>200 && unit<=350){
      Console.WriteLine("the consumed unit is{0} and the total price is{1}",unit,(unit-200)*3+400);
    }
    else if(unit>=351 && unit<=500){
      Console.WriteLine("the consumed unit is{0} and the total price is{1}",unit,(unit-350)*5+850);
    }
    else{
      Console.WriteLine("the consumed unit is{0} and the total price is{1}",unit,(unit-500)*7+1100);
    }
  }
}