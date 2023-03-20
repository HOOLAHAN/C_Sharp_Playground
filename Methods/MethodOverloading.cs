using System;

namespace MethodOverloading
{
  class Program
  {
    static void Main(string[] args)
    {
      // The method with the corresponding parameters will be called
      NamePets("Laika", "Albert");
      NamePets("Mango", "Puddy", "Bucket");
      NamePets();

    }
    static void NamePets(string name1, string name2)
    {
      Console.WriteLine($"Your pets {name1} and {name2} will be joining your voyage across space!");
    }
    static void NamePets(string name1, string name2, string name3)
    {
      Console.WriteLine($"Your pets {name1}, {name2} and {name3} will be joining your voyage across space!");
    }
    static void NamePets()
    {
      Console.WriteLine("Aw, you have no spacefaring pets :(");
    }
  }
}


// Say you want to use Math.Round(), a built-in method. You go to the Microsoft documentation to learn how to use it, and find at least 8 different versions! They all have the same name: Math.Round().

// What’s happening here is called method overloading, and each “version” is called an overload. 
// Though they have the same name, the overloads are different because they have either (i) different parameter types or (ii) different number of parameters. 
// This is useful if you want the same method to have different behavior based on its inputs.

// In C#, when we say that the methods are “different”, we are really talking about their method signatures, which is the method’s name and parameter types in order.