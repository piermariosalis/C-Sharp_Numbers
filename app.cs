// Addition
int firstNumber = 10;

int secondNumber = 34;

Console.WriteLine(firstNumber + secondNumber);

int thirdNumber = 4500;
int fourthNumber = 3589;
int sum = thirdNumber + fourthNumber;

// Implicit conversion type
Console.WriteLine("The sum of " + thirdNumber + " plus " + fourthNumber + " is " + sum);



string name = "Pier";

int number = 27;

//  overloading an operator
Console.WriteLine(name + " and " + number ); //string output

Console.WriteLine(name + " and " + number + 7 ); //string output

// String concatenation and addition use the "+" operator

// Order of operations

Console.WriteLine(name + " and " + (number + 7) ); //with () the compiler knows that is a sum

// output Pier and 34 (27 + 7)

//Difference

int difference = 7 - 5;

Console.WriteLine(difference);
//Product

int product = 9 * 8;

Console.WriteLine(product);

//Quotient

int quotient = 25 / 5;

Console.WriteLine(quotient);

//Decimal quotient

decimal decimalQuotient = 7.0M/ 5;

Console.WriteLine(decimalQuotient);

// Casting conversion type

int numOne = 7;

int numTwo = 5;

decimal result = (decimal)numOne / (decimal)numTwo;

Console.WriteLine(result);

// Remainder of division - % remainder operator

int dividend = 10;

int diviser = 2;

Console.WriteLine("Modulus of 10 / 2 is: " + (dividend % diviser));

if(dividend % diviser == 0) {
    Console.WriteLine("dividend is divisible for diviser");
} else {
    Console.WriteLine("dividend is not divisible for diviser");

}

// PEMDAS ( ORDER OF OPERATIONS) :

//Parentheses (whatever is inside the parenthesis is performed first)
//Exponents (there's no exponent operator in C#, you can use the System.Math.Pow() method, which is available from the .NET Class Library. )
//Multiplication and Division (from left to right)
//Addition and Subtraction (from left to right)

int value1 = 5 + 5 + 240 * 20;

int value2 = (5 + 5 + 240) * 20;

Console.WriteLine(value1 + " & " + value2);

int value3 = 900 / 8 * 50;

int value4 = 900 / (8 * 50);

Console.WriteLine(value3 + " & " + value4);


// Increment and decrement values
// Compound assignment += , -=, *=, ++, -- , /=

// Operator +=
/*
int value = 0;
Console.WriteLine(value);

value = value + 5;
Console.WriteLine(value);

value += 5;
Console.WriteLine(value);

// Operator ++ (icrements one value)

int value2 = 5;
Console.WriteLine(value2);

value2 = value2 + 1;
Console.WriteLine(value2);

value2++;
Console.WriteLine(value2);

// Operator -- (decrements one value)

int value3 = 10;
Console.WriteLine(value3);

value3 = value3 - 1;
Console.WriteLine(value3);

value3--;
Console.WriteLine(value3);

int test = 10;

test /= test;
Console.WriteLine(test);

test /= test - 5;

Console.WriteLine(test);

// Increment or decrement

int gamePoints = 1;
Console.WriteLine(gamePoints);

gamePoints = gamePoints + 1;
Console.WriteLine($@"First Increment: {gamePoints}");

gamePoints += 1;
Console.WriteLine($@"Second Increment: {gamePoints}");

gamePoints++;
Console.WriteLine($@"Third Increment: {gamePoints}");

gamePoints = gamePoints - 1;
Console.WriteLine($@"First Decrement: {gamePoints}");

gamePoints -= 1;
Console.WriteLine($@"Second Decrement: {gamePoints}");

gamePoints--;
Console.WriteLine($@"Third Decrement: {gamePoints}");

*/

int value = 10;
Console.WriteLine(value);
value++;

value++;
Console.WriteLine(value);


++value;
Console.WriteLine(value);



