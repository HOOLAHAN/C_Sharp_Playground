using System;

namespace GettingInput
{
  class DataTypesAndVariables
  {
    static void Main()
    {
      Console.WriteLine("How old are you?");
      string input = Console.ReadLine();
      Console.WriteLine($"You are {input} years old!");

      // string isString = "string";
      // int one = 1;
      // bool isTrue = true;
      // float isFloat = 6.23445;
      // decimal isDecimal = 6.2323245m;
      // double isDouble = 65.22;

      int numberOne = 124345;
      double numberOneSqrt = Math.Floor(Math.Sqrt(numberOne));

      // dna strand
      string startStrand = "ATGCGATGAGCTTAC";

      // find location of "tga"
      int tga = startStrand.IndexOf("TGA");

      // start point and stop point variables
      int startPoint = 0;
      int length = tga + 3;

      // define final strand
      string dna = startStrand.Substring(startPoint, length);
      Console.WriteLine(dna);

      // DNA mutation search at index 3
      Console.WriteLine(dna[3]);

      // Make lower case
      string startStrandLower = startStrand.ToLower();

    }
  }
}

// To run the code in the console use command : 
// dotnet run

// Data Types - CheatSheet
// https://content.codecademy.com/courses/learn-c-sharp/data-types-variables/C%23%20Data%20Types%20Cheat%20Sheet.pdf?_gl=1*tyxj27*_ga*NDI2ODIwNjQ4NC4xNjYwMTQ5Njk3*_ga_3LRZM6TM9L*MTY3NzUyNDU2Mi40MC4xLjE2Nzc1MjY5NzcuMC4wLjA.

// Reserved words (words you cannot use to define a variable):
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/

// Microsoft documentation for converting a class:
// https://learn.microsoft.com/en-us/dotnet/api/system.convert?view=netframework-4.7.2 

// Converting a string to a number:
// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/how-to-convert-a-string-to-a-number

// .NET API browser
// https://learn.microsoft.com/en-us/dotnet/api/