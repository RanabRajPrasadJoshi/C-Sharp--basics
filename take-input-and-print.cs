// take input and print
using System;
class HelloWorld {
  static void Main() {
    Console.Write("Enter your Name: ");
    string name = Console.ReadLine();
    Console.Write("Enter your Country: ");
    string country = Console.ReadLine();
    Console.Write("Enter your age: ");
    int age =Convert.ToInt32( Console.ReadLine());
    
    Console.WriteLine("using Text formater");
    Console.WriteLine($"Hey, Its me {name} from {country},and my age is {age} \n \n");
    
    Console.WriteLine("Without using Text formater");
    Console.WriteLine("Hey, Its me "+ name +" from " + country + ",and my age is " + age);

  }
}