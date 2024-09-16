// fabonacci number without third variable
using System;
class HelloWorld {
	static void Main() {
		Console.WriteLine("Enter the number");
		int number = Convert.ToInt32(Console.ReadLine());

		int val1 = 0;
		int val2 = 1;

		while(val1<number){
			Console.Write(val1 + " ");
			val1 += val2;
			val2 = val1 - val2;
		}
	}
}