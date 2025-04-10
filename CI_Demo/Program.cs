using System;
using System.Numerics;
using CI_Demo;

Calculator calculator = new Calculator();

Console.WriteLine("Welcome to our calculator!");

Console.WriteLine("Chose a function");
Console.WriteLine("For addition press A");
Console.WriteLine("For subtraction press B");
Console.WriteLine("For division press C");
Console.WriteLine("For multiplication press D");
Console.WriteLine("For squareroot press E");
Console.WriteLine("For powers press F");

string choice = Console.ReadLine();
switch (choice)

{
	case "A": Addition();
		break;
	default:
		break;
}

void Addition()
{
	Console.WriteLine("Type your first number:");
	string FirstNumber = Console.ReadLine();

	Console.WriteLine("Type your secoond number:");
    string SecondNumber = Console.ReadLine();

	int Answer = calculator.Add(int.Parse(FirstNumber), int.Parse(SecondNumber));
	Console.WriteLine($"The answer is {Answer}"); 
}



