//Conditionals

//Handles making decisions w/n an application

//Anytime we want an application to do work based on any condition.

//Ex:
//If user is logged in, redirect the user to the login page
//It its the users birthday, tell them HAPPY BIRTHDAY
//If the user does not fit the neccessary role, then deny them access.

bool isRaining = true;
bool isGoingOutside = true;

//If statements
//Formula:
//Given a boolean, if the boolean evaluates to 'true' do the action you're given.

//if(true/false value)
//(
//body of the code will execute based on above boolean
//)

//basically
//if(isRaining)
//{
//System.Console.WriteLine("it's raining out!");
//}

//Multiple if statements
//if(isRaining && isGoingOutside)
//System.Console.WriteLine("Better bring out the umbrella!");

if(isRaining && isGoingOutside)
{
    System.Console.WriteLine("Better bring out the umbrella!");
}

//Or
//if(!isRaining || isGoingOutside==false)
//{
    //System.Console.WriteLine("I don't need an umbrella");
//}

//OR
//if(isRaining ^ isGoingOutside)
//{ 
    //System.Console.WriteLine("I will go outside if it is not raining.");
//}

//Write an if statement that uses a new boolean called 'hasUmbrella' that will print
//to the Console if the user has an umbrella and is going outside
//while it's raining

//Example of expected output:
//Good thing I have my umbrella so I can go outside while it's raining!

bool hasUmbrella = true;

//if(isRaining && isGoingOutside)
//{ if(hasUmbrella)
    //System.Console.WriteLine("Gosh darnnit - looks like i'm giving my presentation wet!");
//}

if(isRaining && isGoingOutside && hasUmbrella)
{ 
        System.Console.WriteLine("Gosh darnnit - looks like i'm giving my presentation wet!");
}