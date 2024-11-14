using System;
class HelloWorld {
  static void Main() {
      string star = "*";
      string startemp = "**";
    for(int i=10; i>=1 ; i--){
        for(int j=0;j<i;j++){
            Console.Write(" ");
        }
        Console.Write(star);
        star = startemp + star;
        Console.WriteLine("");
    }
  }
}