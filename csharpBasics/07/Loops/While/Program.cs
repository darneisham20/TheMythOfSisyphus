
//Loops
// we use these to repeat lines of code
// We can have a specific operation, function, and 'wrap' it around 

//while loops
// we will define a variable -> this will be used for the while loops boolean expression
int number =0;

//While number is less than or equal to 100, lets do the following:

while(number <=100){
    //Write to the console
    System.Console.WriteLine(number);
    //count up by one, so that "we can have a way to exit the loop"
    number++;
    //+number++
    //number+=1;
}

//INFINITE LOOPS (OUR ENEMY)

/*
    while(number ==0)
    {
        Console.WriteLine(OH, S**T!)
    }
*/

//we can control the behaviour

int value2 =1;

while(value2>2){
    value2--;
    
    if(value2==90){
        System.Console.WriteLine("We are going to Jump out of the loop");
        break;
    }
    if (value2==80){
        System.Console.WriteLine("We will just return or leave the loop.");
        return;
    }
    if(value2==10)
    {
        System.Console.WriteLine($"Let's just carry on with the loop.{value2}");
        continue;
    }
}