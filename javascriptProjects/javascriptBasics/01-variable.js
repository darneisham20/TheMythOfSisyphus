/* Variables

Variables are a 'reference back to a particular memory address that live in RAM)
Value: the thing that resides at the address referred to by the variable */

// Javascript Declaration
var myFirstVariable;

//Declaration
var patientID;

// Initialization
patientID = 12003;

// Declaration
var lastName;

// Initialization
lastName = "Doe";

/* You can re-initialize a variable with another value 
even after it has been initialized before, just follow the same procedure as initialization */

//Re-Initialization
lastName = "Smith";

/* We can declare a variable and initialize it with a value all in one line: */

//Declaration and Initialization//
var orangeJuiceContainer = "empty";

/* More variable keywords:

    var- first variable keyword introduced in the langauge.
    let- keyword that allows you to declare a -mutable- variable, meaning you can it can always be initialized
        again with a completely different variable. USE LET WHEN CREATING MUTABLE VARIABLES
    const - keyword used to declare 'constant' variables, which cannot be modified once you declare and 
        initialize it. When you declare a constant, you must initialize it with a value.
        IF YOU DON'T WANT IT TO CHANGE; DECLARE IT AS A CONSTANT.
*/

//Behavior

// Var and Hoisting
programmer = "Ada Lovelace";
var programmer;

// Let and Hoisting
jsVersion = "es6"
let jsVersion;

// Const and Re-Initialization
const humansBestFriend = "dog";
humansBestFriend = "frog";

