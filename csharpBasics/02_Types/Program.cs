//C# Types

//variable naming Convention:
//camel-cased (typeName) 
//first letter lowercase, all other 'first letters' uppercase

//bool -> true / false
bool isLoggedIn = true;
System.Console.WriteLine(isLoggedIn);

//integers -> Whole Numbers
int age = 31;
System.Console.WriteLine(age);   //.ToString()...

//decimal -> very precise
//need m suffix to show that the value is a decimal
decimal accountBalance = 100_000m;
System.Console.WriteLine(accountBalance);

int i = 0;                  //32bit integer value
short sh = 32767;           // 16bit integer value
Int16 anotherShortEx = 32000;
byte by = 255;              // a group of binary digits (usually eight) operated on as a unit;

string s = "hey!";          // a collection of characters;
                            // this reference type defaults to null
char c = 'i';               //a single character.

string s2 = @"a\tree";      //use the @ to specify a directory

bool b = false;             //true //false

long L = 7;                 // this is A LARGE INTERGER VALUE. x2:
                            // -9Q - 9Q (data science)
decimal d = 99.999m;        // 'm' 128-bit precision, 28-29 decimal places - used for $$$

double db = 7.8000d;        // 'd' 15-16 digits w/ a 64 bit size

float  f  = 10.8f;          // 'f' stored in 32 bits, 1/2 the size of a double

int?  ni  = null;           // int is a Struct. it defaults tos zero, but if we (int?)
                            // we turn int to a "nullable int"

// dealing with decimals
System.Console.WriteLine(1.25870587580515014451124984121085f);
System.Console.WriteLine(1.25870587580515011484451121085d);
System.Console.WriteLine(1.258705875805150144511134721085m);

//DateTime
DateTime Today = DateTime.Today;

//we can make our own date
DateTime birthday = new DateTime(1972,06,20);

//Enums types that are represented by numbers.
PastryType myPastry = PastryType.Cake;
PastryType anotherOne = PastryType.Croissant;
System.Console.WriteLine("I Like " + myPastry+" and " + anotherOne);