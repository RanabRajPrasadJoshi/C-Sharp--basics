// check wether the number is prime number or not
using System;
class HelloWorld {
	static void Main() {
		Console.WriteLine("Enter the number");
		int number = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        
        for(int i = 1; i<=number ; i++){
            if(number%i==0){
                count ++;
            }
        }
	    if (count>2){
	        Console.WriteLine("Not a prime number");
	    }
	    else{
	        Console.WriteLine("Prime Nnmber");
	    }
	}
}