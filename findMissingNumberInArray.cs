using System;
class HelloWorld {
  static void Main() {
   int[] num = {1,2,3,5};
   int greatest = 0;
   foreach(int n in num){
       if(n>greatest){
           greatest = n;
       }
   }
   int lastIndex = num[num.Length-1];
   if(lastIndex!=greatest){
       Console.WriteLine("The last number in the array must be the greastest number Try again by changing it");
       return;
   }
   else{
   int currentindex=0;
   Console.Write("missing number are: " );
   int tempo = 0;
   for(int i=1;i<=lastIndex;i++){
       if(num[currentindex]==i){
           currentindex++;
       }
       else{
           Console.Write(i + " ");
           tempo ++;
       }
   }
   if(tempo==0){
       Console.Write("none of the number are missing");
   }
   }
  }
}