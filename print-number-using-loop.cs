// print up to given number using loop
using System;
class HelloWorld {
  static void Main() {
    Console.Write("Enter your Number: ");
    int number = Convert.ToInt32 (Console.ReadLine()); // value can be declare directly too without taking input
    
    for(int i = 1;i<=number;i++){
        Console.WriteLine(i);
    }
    

  }
}