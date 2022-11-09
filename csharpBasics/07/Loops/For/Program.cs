//For loops


//1. initializer
//2. condition
//3. iterator ++, --, +=, -=, /=
    //1         //2     //3
for (int i = 0; i < 100; i++)
{
    //body of the for-loop
    System.Console.WriteLine(i);
}

//Challenge
//Prompt the user for a number to count from zero
System.Console.WriteLine("Pick a number any number:");

//take the user input and store it
int userInput = int.Parse(Console.ReadLine());

//loops all number from zero to the number given by the the user
for (int i = 0; i < userInput; i++)
{
    System.Console.WriteLine(i);
}