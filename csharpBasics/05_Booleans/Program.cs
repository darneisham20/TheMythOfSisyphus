//Booleans

// can hold true / false

bool isCool = false;
isCool = true;

//todo: Booleans and logical operators
//Operators that perform logic
//*    AND
//*    OR
//*    NOT

//NOT
//C# has a logical negation operator, 
//or what we call the bang operator (!)
// "!isCool" evaluates to the opposite of whatever value isCool is holding

//AND 
// C# uses ampersands (&) to indicate AND statements
// A single (&) evaluates bothe conditions always
// the (&&) only evaluate the right side if it is required

//OR
// C# uses (|) to idicate or statements
//Similar to AND, one pipe checks both conditions
// (||) will evaluate the first then the right

//XOR
// C# uses the caret character (^) indicates XOR statements.

//--Boolean Operators

//todo: Negation Operator
bool isTrue = !false;
bool isFalse = !true;

//todo: And Operator
 // true b/c BOTH HAVE TO BE TRUE!
bool trueAndExample = true && true;
bool falseAndExample = true && false; 
//false b/c only one met conditions for true

//todo: Or Operator
bool trueOrExample = true || false;
bool falseOrExample = false || false;

//todo: XOR Operator
bool trueExclusiveOr = true ^ false;
bool falseExclusiveOR = true ^ true;

//Examples
Console.WriteLine($"NOT False = {isTrue}");
System.Console.WriteLine($"False AND True = {falseAndExample}");
System.Console.WriteLine($"True OR True = {trueOrExample}");
System.Console.WriteLine($"True XOR True = {falseExclusiveOR}");

//--Comparison Operator

bool isGreaterThan = 10 > 10;
bool isGreaterThanOrEqualTo = 10 >= 10;
System.Console.WriteLine($"10 > 10 is {isGreaterThan}, and 10 >= 10 is {isGreaterThanOrEqualTo}");

bool isLessThan = 5 < 5;
bool isLessThanOrEqualTo = 5 <= 5;
Console.WriteLine($"5 < 5 is {isLessThan}, while 5 <= 5 is {isLessThanOrEqualTo}");

bool equality = 17 == 9;
bool inequality = 17 != 9;
Console.WriteLine($"17 == 9 and 17 != 9 are {equality} and {inequality}, respectively.");