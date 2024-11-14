// creating nepal flag patern using nested for loop . flag is made of "*"
using System;
class HelloWorld {
  static void Main() {
    for(int i=1; i<=4 ; i++){
        for(int j=1 ; j<=i ; j++){
            Console.Write("*");
        }
        Console.WriteLine("");
    }
    
    for(int i=2; i<=6 ; i++){
        for(int j=1 ; j<=i ; j++){
            Console.Write("*");
        }
        Console.WriteLine("");
    }
  }
}
