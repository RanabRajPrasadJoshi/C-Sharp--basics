// check the word is palidrome or not
using System;
class HelloWorld {
	static void Main() {


		Console.Write("Enter the word: ");
		string word = Console.ReadLine();
		string reverse = "";
		int length =0;
        foreach (char c in word){
            length++;
        }
        for(int i = length - 1 ; i>=0 ; i--){
            reverse += word[i];
        }
        if(word == reverse){
            Console.WriteLine("Palidrome");
        }
        else{
            Console.WriteLine("Not Palidrome");
        }




	}
}