// even total using loop
using System;
class HelloWorld {
	static void Main() {
		Console.WriteLine("Enter the number");
		int number = Convert.ToInt32(Console.ReadLine());

		int total = 0;
		
		//option 1
		
		for(int i =0; i<number;i+=2){
		    total +=i;
		}
		Console.WriteLine(total);
		
		// option 2 
		
	/* 
	    for(int i =0; i<number;i++){
		    if(i%2==0){
		        total+=i;
		    }
		}
		Console.WriteLine(total); 
		*/
	}
}