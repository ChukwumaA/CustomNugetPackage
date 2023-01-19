# Task-5
Application of all things learnt.


## This is a class library that can perform addition, subtraction, multiplication division and accepts any number and logs it to the console.

How to use this Nuget Package

Install the nugetpackage using the dotnet cli command: or using the nuget package manager in your IDE.

Import the using statement as such  ##"using NugetPackage;"

**YourClass yourClass = new YourClass();

**yourClass.YourMethod();

This package can only accept integers data types as arguments and only display integer data types in the console window.

You can perform any of the stated operations using the class calls above.

Example 

        Operation op = new Operation();
  
        Console.WriteLine(op.Addition(10, 20));

        Console.WriteLine(op.Subtraction(10, 20));

        Console.WriteLine(op.Multiplication(10, 20));

        Console.WriteLine(op.Division(10, 20));

        Console.WriteLine(op.PrintNumbers(254574545));

        Console.ReadLine();
