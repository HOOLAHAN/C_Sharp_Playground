using System;

namespace Return
{
  class MethodOutput
  {
    static void Main(string[] args)
    {
      Console.WriteLine(DecoratePlanet("Jupiter"));

      // Exercie using OUT!
      // A method can only return one value, but sometimes you need to output two pieces of information. 
      // Calling a method that uses an 'out' parameter is one way to return multiple values.
      string ageAsString = "102";
      string nameAsString = "Granny";
      int ageAsInt;
      bool outcome;
      // converts string to integer
      outcome = Int32.TryParse(ageAsString, out ageAsInt);
      Console.WriteLine(outcome);
      Console.WriteLine(ageAsInt);
      int nameAsInt; // True (can be done)
      bool outcome2; // 102
      // converts string to integer
      outcome2 = Int32.TryParse(nameAsString, out nameAsInt);
      Console.WriteLine(outcome2); // False
      Console.WriteLine(nameAsInt); // 0 (can't be done)

      // Using Out
      string statement = "GARRR";
      Console.WriteLine(Whisper(statement, out bool marker));

    }
    // Method returning a string
    static string DecoratePlanet(string planet)
    {
      return $"*.*.* Welcome to {planet} *.*.*";
    }

    // Method returning a boolean
    static bool IsPlutoADwarf()
    {
      bool answer = true;
      return answer;
    }

    static string Whisper(string statement, out bool marker)
    {
      marker = true;
      Console.WriteLine(marker);
      return statement.ToLower();
    }



	}
}
