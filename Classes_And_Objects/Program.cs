using System;

namespace BasicClasses
{
  class Program : Forest
  {
    static void Main(string[] args)
    {
      // // make an instance of the Forest class and store as a variable f
      // Forest f = new Forest();
      // // set the values of the 4 fields of Forest
      // f.name = "Amazon";
      // f.biome = "Tropical";
      // f.trees = 390;
      // f.age = 10;
      // // print the name field to the console
      // Console.WriteLine(f.name);

      // Call the new constructor in Main() to create a Forest object with the name “Congo” and biome “Tropical”.
      Forest f = new Forest("Congo", "Desert");
      Console.WriteLine(f.Name);
      Console.WriteLine(f.Biome);

    }
  }
}
