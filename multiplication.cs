// accouring to user input number provide the multiplication table up to in put given by user
using System;
class HelloWorld {
	static void Main() {


		Console.Write("Enter the number: ");
		int number = Convert.ToInt32(Console.ReadLine());
        
        for(int i = 1 ; i<=number; i++){
            Console.WriteLine("Table of " + i);
            for(int j =1; j<= number; j++){
                Console.WriteLine(i + " X " + j + " =  " + i *j);
            
            Console.WriteLine("\n \n");
        }




	}
}
