using System;

namespace LogicalOperators
{
  class LogicAndConditionals
  {
    static void Main(string[] args)
    {
      bool beach = true;
      bool hiking = false;
      bool city = true;

      // Logical Operators
      bool yourNeeds = beach && city;
      bool friendNeeds = beach || hiking;
      bool tripDecision = yourNeeds && friendNeeds;
      Console.WriteLine(tripDecision);

      // Control Flow 
      int guests = 0;
      if (guests >= 4)
      {
        Console.WriteLine("Catan");
      }
      else if (guests >= 1 && guests <= 3)
      {
        Console.WriteLine("Innovation");
      }
      else
      {
        Console.WriteLine("Solitaire");
      }

      // Switch Statements
      string color = Console.ReadLine();
      switch (color)
      {
        case "blue":
          // execute if the value of color is "blue"
          Console.WriteLine("color is blue");
          break;
        case "red":
          // execute if the value of color is "red"
          Console.WriteLine("color is red");
          break;
        case "green":
          // execute if the value of color is "green"
          Console.WriteLine("color is green");
          break;
        default:
          // execute if none of the above conditions are met
          break;
      }

      // Ternary Operators
      string colour = "blue";
      string result = (colour == "blue") ? "blue" : "NOT blue";
      Console.WriteLine(result);


    }
  }
}
