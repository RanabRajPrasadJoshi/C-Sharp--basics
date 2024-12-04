
using System;
class HelloWorld {
  static void Main() {
    int [] arr = {1,2,3,4,5};
    int len = arr.Length;
    int [] result = new int [len];
    
    for(int i=0;i<len;i++){
        result[i] = arr[(len -i)-1];
    }
    for(int i=0; i<len;i++){
        Console.Write(result[i] + " ");
    }
  }
}