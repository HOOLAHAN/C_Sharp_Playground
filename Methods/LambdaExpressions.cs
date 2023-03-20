using System;

namespace AlternateExpressions
{
  class LambdaExpressions
  {
    static void Main(string[] args)
    {
      string[] spaceRocks = {"meteoroid", "meteor", "meteorite"};
      
      // Using a lambda to give the same result as passing in HitGround
      bool makesContact = Array.Exists(spaceRocks, (string s) => (s == "meteorite"));
      

      if (makesContact)
      {
        Console.WriteLine("At least one space rock has reached the Earth's surface!");
      } 

    } 
    
    static bool HitGround(string s)
    {
      return s == "meteorite";
    }
  }
}

// Lambda Shortcuts:
// We can remove the parameter type if it can be inferred
// We can remove the parentheses if there is one parameter

