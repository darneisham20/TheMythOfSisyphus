//* Remember, variable are 'containers', in C# we just SMACK a label on them.
//1 Type //2 variable name  //3 assignment operator //4 value
string    firstName    =                    "Zach";

//todo: 1 Type
//todo: 2 variable name
//todo: 3 assignment operator
//todo: 4 value

Console.WriteLine(firstName);

Console.WriteLine("What is your favorite color?");

//declare a string color and we want to assign whatever the user types.
string color = Console.ReadLine();   // Returns a 'string' type

Console.WriteLine("Your said your favorite color is " + color);
// The above is an example of "String Concatination"

Console.WriteLine("What is your name?");

string newName = Console.ReadLine();

Console.WriteLine("OK, so your name is " + newName);