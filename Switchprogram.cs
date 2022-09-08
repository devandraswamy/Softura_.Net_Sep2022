using System;

class Switch1{

 public static void Main(){
        Console.WriteLine("Enter The Package You want\n A or B or C");
        string package=Console.ReadLine();
        switch(package){
            case "A":
            Console.WriteLine("PACKAGE A CONSIST OF\n *South Special\n*Children Club\n*Movie Price:250");
            break;
            case "B":
            Console.WriteLine("PACKAGE B CONSIST OF\n *News\n*Sports\n*Movies\n*Regional-2 Price:450");
            break;
            case "C":
            Console.WriteLine("PACKAGE C CONSIST OF\n*Discovery Histroy National Price:450");
            break;
            default:
            Console.WriteLine("please enter valid package  code");
            break;
            
            
        }
        
        }
}