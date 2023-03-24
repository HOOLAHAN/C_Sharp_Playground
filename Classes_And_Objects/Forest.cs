using System;

namespace BasicClasses
{
  class Forest
  {
    public string biome;

    // define Name using automatic property
    public string Name
    { get; set; } 
    
    // basic pattern for an imaginary size property:
    public int Trees
    {
      get { return trees; }
      set { trees = value; }
    }
    
    // Define a Biome property for the biome field. It will have a getter and setter. The setter should only allow three values: "Tropical", "Temperate", and "Boreal". If any other value is used, set biome to "Unknown".
    public string Biome
    {
      get { return biome; }
      set 
      { 
        if (value == "Tropical" || 
        value == "Temperate" || 
        value == "Boreal")
        {
          biome = value;
        } 
        else
        {
          biome = "Unknown";
        }
      }
    }

    // define an Age property for the age field. It should have a public getter and a private setter.    
    public int Age
    {
      get { return age; }
      private set { area = value; }
    }

    // In the Forest class, define a public method Grow(). It should:
      // take zero arguments
      // increase the Trees property by 30 and the Age property by 1
      // return the updated number of trees

    public int Grow() 
    {
      Trees = Trees + 30;
      Age++;
      return Trees;
    }

    public int Burn ()
    {
      Trees = Trees - 20;
      Age++;
      return Trees;
    }

    // Define a constructor for the Forest class. It should have two parameters:
      // name, which sets the Name property
      // biome, which sets the Biome property
      // It should also set the value of Age to 0.
    public Forest(string name, string biome)
    {
      this.Name = name;
      this.Biome = biome;
      Age = 0;
    }

  }

}


// Access modifiers
// public — a public member can be accessed by any class
// private — a private member can only be accessed by code in the same class

// Since a class’ properties define how other programs get and set its fields, it’s good practice to make fields private and properties public.