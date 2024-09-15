// factorial of positive integer
using System;
class HelloWorld {
	static void Main() {
		Console.WriteLine("Enter the number");
		int number = Convert.ToInt32(Console.ReadLine());

		int total = 1;
		
		//option 1
		
		for(int i =1; i<=number;i++){
		    total *=i;
		}
		Console.WriteLine(total);
	
	}
}