// check the strength of password
using System;
class HelloWorld {
	static void Main() {
		Console.Write("Enter the password: ");
		string password = Console.ReadLine();
		bool is_upper = false, is_lower = false , is_symbol = false , is_number = false;
		int score = 0;
		if(password.Length <7){
		    Console.WriteLine("Too weak");
		    return;
		}
		else{
		    score++;
		    foreach (char c in password){
		    if(char.IsUpper(c)){
		        is_upper = true;
		        
		    }
		    if(char.IsLower(c)){
		        is_lower = true;
		        
		    }
		    if("1234567890".Contains(c)){
		        is_number = true;
		        
		    }
		    if("!@#$%^&*".Contains(c)){
		        is_symbol = true;
		    }
		    }
		}
		if(is_upper){
		score++;
		}
		if(is_lower){
		score++;
		}
		if(is_number){
		score++;
		}
		if(is_symbol){
		score++;
		}
		
		switch(score){
		    case 2:
		        Console.WriteLine("Weak with score " + score);
		        break;
		    case 3:
		        Console.WriteLine("Normal with score " + score);
		        break;
		    case 4:
		        Console.WriteLine("strong with score " + score);
		        break;
		    case 5:
		        Console.WriteLine("Very strong with score " + score);
		        break;
		}
	}
}