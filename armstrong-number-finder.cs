// print up to given number using loop
using System;
class HelloWorld {
  static void Main() {
    Console.Write("Enter your number: ");
    int number = Convert.ToInt32 (Console.ReadLine()); // value can be declare directly too without taking input
    int temo = number;
    int num = number;
    int total = 0;
    int len=0;
    
    while(temo>0){
        temo /= 10;
        len++;
    }
    
    for (int i = 0;i<len;i++){
        int ttpp =num%10;
        total += (int)Math.Pow(ttpp , len);
        num /=10;
    }
    
    if(number == total){
        Console.Write("Armstrong Number");
    }
    else{
        Console.Write("Not a Armstrong Number");
    }

  }
}