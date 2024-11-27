// check the word is palidrome or not
using System;
class HelloWorld {
	static void Main() {


		Console.Write("Enter the word: ");
		string word = Console.ReadLine();
		string reverse = "";
		int length =0;
        foreach (char c in word){
            reverse += word[c];
        }
        
        if(word == reverse){
            Console.WriteLine("Palidrome");
        }
        else{
            Console.WriteLine("Not Palidrome");
        }




	}
}