/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    int[] numbers = {11,22,33,44,56};
    int total = 0 ;
    Console.WriteLine("Printed array numbers are: ");
    foreach(int number in numbers){
        Console.WriteLine(number);
        total +=number;
    }
    Console.WriteLine("sum of all numbers in array is : "+ total);
    float average = (float)total / numbers.Length;
    Console.WriteLine("Averge is: "+ average);
    int tempMax = 0;
    foreach(int number in numbers){
        if(number>tempMax){
            tempMax = number;
        }
    }
    
    int tempMin = tempMax;
    foreach(int number in numbers){
        if(number<tempMin){
            tempMin = number;
        }
    }
   Console.WriteLine("Largest number in array is: "+ tempMax);
   Console.WriteLine("Smallest number in array is: "+ tempMin);
}
}