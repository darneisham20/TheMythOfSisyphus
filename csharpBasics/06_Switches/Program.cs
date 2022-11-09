// Switch
// 'switch' keyword
// like 'if' statements, but does away with "branching"

//1. value thats going to be evaluated

//2. "value" will be checked w/n the switch statement by a "case"

//3. "break" to indicate that we want to leave the switch statement

//4. "default" -> if all else fails

Ex:
System.Console.WriteLine("Please input your name");
string name = Console.ReadLine();

//todo: we are going to switch on this 'name' value:
switch (name)
{   //this is the bale passed in which is being "checked" by case (2)
    case "Zach":
    System.Console.WriteLine("Hi, Zach");
    //we have to leave the switch staement to prevent 'falling-through'
    break;
    //so, if the user types any other name, then:
    default:
    System.Console.WriteLine("Invalid Option (Name");
    break;
}

System.Console.WriteLine("How are you feeling (1-5)?");
string userInput = Console.ReadLine();

switch (userInput)
{
    case "1":
        System.Console.WriteLine("I hope your day gets better");
        break;
    case "2":
        System.Console.WriteLine("Oh, sorry to hear that.");
        break;
    case "3":
        System.Console.WriteLine("Oof");
        break;
    case "4":
        System.Console.WriteLine("Nice");
        break;
    case"5":
        System.Console.WriteLine("Bro that's sick");
        break;
    default:
    System.Console.WriteLine("Invalid Key Input");
    break;
}

//Challenge
//Creating a switch statement
//Want to output descriptions for a few of your friends
//Prompt the user's input to enter a friend's name
//Take in a user's input from the Console
//If the input is one of the listed friends write a fact about that person to the Console

//Extra Challenge:
        // What can you do with cases like "Devon" and "devon" as these are different values?


