// calculator
using System;
class HelloWorld {
	static void Main() {
	    bool flag = true;
	    while(flag){
		Console.WriteLine("Enter 1 for addition ");
		Console.WriteLine("Enter 2 for subtraction ");
		Console.WriteLine("Enter 3 for multiplication ");
		Console.WriteLine("Enter 4 for division ");
		Console.WriteLine("Enter 5 or more for exit ");
		int select = Convert.ToInt32(Console.ReadLine());
		Console.Write("\n");
		if(Math.Abs(select)>4){
		    Console.WriteLine("ThankYou....");
		    flag = false;
		    break;
		}
		
		else{
		    Console.Write("Enter num 1: ");
		    int num1 = Convert.ToInt32(Console.ReadLine());
		    Console.Write("Enter num 2: ");
		    int num2 = Convert.ToInt32(Console.ReadLine());
		    switch(Math.Abs(select)){
		        case 1:
		            Console.WriteLine("addition = "+ num1+num2 + "\n");
		            break;
		        case 2:
		            Console.WriteLine("subtraction = "+ (num1-num2)+ "\n");
		            break;
		        case 3:
		            Console.WriteLine("multiplication = "+ num1*num2+ "\n");
		            break;
		        case 5:
		            Console.WriteLine("division = "+ num1/num2+ "\n");
		            break;
		        default:
		            Console.WriteLine("Try again");
		            break;
		    }
		}
	    }
	
	}
}