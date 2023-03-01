using System;

namespace CallAMethod
{
  class Methods
  {
    static void Main(string[] args)
    {
      string msg = "Yabba dabba doo!";
      
      // Math.Min() method
      Math.Min(3, 1);
      
      Console.WriteLine(msg);

      // Get the first letter of the msg string using Substring().
      Console.WriteLine(msg.Substring(0, 1));

      string designer = "Anders Hejlsberg";

      // find the index of the space (" ") in the string designer and store it in a variable indexOfSpace.
      int indexOfSpace = designer.IndexOf(" ");

      // Use Substring() and the variable indexOfSpace to get the second name. Store the returned value in a variable secondName.
      string secondName = designer.Substring(indexOfSpace + 1);
      Console.WriteLine(secondName);

      VisitPlanets(3);

      YourMethodName("I'm hungry", "!"); // prints "I'm hungry!"
      YourMethodName("I'm hungry");  // prints "I'm hungry."

      // referring to a parameter by its name to be able to call out of order
      YourMethodName2(d: 4, b: 1, a: 2);

    }
    // Define a method named VisitPlanets() outside of the Main() then call the method inside Main
    static void VisitPlanets(int numberOfPlanets)
    {
      Console.WriteLine($"You visited {numberOfPlanets} new planets...");
    }

    // use = in argument to provide a default value (make it an optional parameter)
    static void YourMethodName(string message, string punctuation = ".")
    {
      Console.WriteLine(message + punctuation);
    }

    static void YourMethodName2(int a = 0, int b = 0, int c = 0, int d = 0, int e = 0) 
    {
      Console.WriteLine(b);
    }

  }
}

// Math.Min Method Documentation
// https://learn.microsoft.com/en-us/dotnet/api/system.math.min?view=net-7.0

// In C#, it’s convention to use PascalCase to name your method. 
// The name starts with an uppercase letter and each word following begins with an uppercase as well. 