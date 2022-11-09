    //Syntax
    //value being evaluated, often a variable
    // The Switch Keyword
    // A body that contains 'cases', called "expression arms", denoted by {}
    // Commas will seperate the "expression arms"
    // Made up of 3 parts

    //1. The expected value, called a "Pattern"
    //2. The "Fat Arrow", denoted as '=>'
    //3. The actual expression (The value returned)
    //4. '_', (this is the default)

    System.Console.WriteLine("Please enter a user name");
    string userName = Console.ReadLine();
    //I need a variable container to store what I'm switching through
    string greeting = userName switch
    {
        "Zach" or
        "zach" or 
        "Z-A-C-H" => "Hello, Zach", //if there are any other cases
        _         => "Who are you?"
    };

System.Console.WriteLine(greeting);

System.Console.WriteLine("How are you feeling (1-5)?");
string userInput = Console.ReadLine();

string userFeeling = userInput switch
{
    "1" => "That sucks",
    "2" => "bummer",
    "3" => "get a netflix show",
    "4" => "get a hulu show",
    "5" => "go watch Severance",
    _ => "Invalid Operation"
};

System.Console.WriteLine(userFeeling);

//Challenge
//We have 2 questions in our code:"
//"How are you feeling today?"
//"How were you feeling yesterday?"

//We got 2 variables
//feelingRating
//yesterdayRating

//The cahllenge is to compare these two values and display how much better or worse
//ther are feeling today than yesterday.

//you don't have to use switch expressions for this challenge.
//use whatever works for you.

//Tools you should think about using:
//Converting string to numbers
//Comparison Operators
//Conditionals