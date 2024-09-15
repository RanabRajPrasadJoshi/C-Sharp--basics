// Generate a random rumber up to 100 and guess it using hint too low and high
using System;
class HelloWorld {
	static void Main() {
	    
	    Random random = new Random();  //created instance or random number generator class
	    int random_number = random.Next(0,99) + 1;  // grnerating random number and adding 1 to make sure number is not zero
	    bool flag = true;
	    while (flag){
		    Console.Write("Enter the number: ");
		    int number = Convert.ToInt32(Console.ReadLine());
            
            if (number>random_number){
                Console.WriteLine("Entered number is greater then random number \n ");
            }
            else if (number<random_number){
                Console.WriteLine("Entered number is smaller then random number \n ");
            }
            else{
                Console.WriteLine("You won the number was " + random_number);
                flag = false;
            }
        
        
	    }
	}
}