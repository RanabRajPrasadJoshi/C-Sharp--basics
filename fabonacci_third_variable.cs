// fabonacci number with third variable
using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Enter the number");
    int number = Convert.ToInt32(Console.ReadLine());
    
    int val1 = 0; 
    int val2 = 1;  
    int total = 0; 
    while (total<number){
        Console.Write(total + " ");
        total = val1 + val2;
        val2 = val1; 
        val1 = total;
        
    }
}
}