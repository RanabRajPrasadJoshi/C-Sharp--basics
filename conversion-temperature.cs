// conversion
using System;
class HelloWorld {
	static void Main() {
	    bool flag = true;
	    while(flag){
		Console.WriteLine("Enter 1 for fahrenheit to celcius ");
		Console.WriteLine("Enter 2 for celcius to fahrenheit");
		Console.WriteLine("Enter 3 or more for exit ");
		int select = Convert.ToInt32(Console.ReadLine());
		Console.Write("\n");
		if(Math.Abs(select)>2){
		    Console.WriteLine("ThankYou....");
		    flag = false;
		    break;
		}
		
		else{
		    Console.Write("Enter temperature ");
		    float temperature = Convert.ToInt32(Console.ReadLine());
		    float output=0;
		    switch(Math.Abs(select)){
		        case 1:
		            output = (temperature - 32) * 5/9;
		            Console.WriteLine("fahrenheit to celcius = "+ output + "\n");
		            break;
		        case 2:
		            output = ( temperature * 9 / 5) + 32 ; 
		            Console.WriteLine("celcius to fahrenheit = "+ output + "\n");
		            break;
		        default:
		            Console.WriteLine("Try again");
		            break;
		    }
		}
	    }
	
	}
}