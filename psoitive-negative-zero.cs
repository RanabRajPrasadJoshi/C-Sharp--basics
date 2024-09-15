// check positive negative and zero
using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Enter the Number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num>0){
        Console.WriteLine("Positive Number");
    }
    else if (num<0){
        Console.WriteLine("Negative Number");
    }
    else{
        Console.WriteLine("zero");
    }
  }
}