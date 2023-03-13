using System;

namespace BuildingArrays
{
  class Arrays
  {
    static void Main(string[] args)
    {
      // defining an array
      string[] summerStrut;
      
      // initializing the array 
      summerStrut = new string[] { 
        "Juice", 
        "Missing U", 
        "Raspberry Beret", 
        "New York Groove", 
        "Make Me Feel", 
        "Rebel Rebel", 
        "Despacito", 
        "Los Angeles" 
      };

      // initializing and defining at the same time
      int[] ratings = { 1, 3, 4, 3, 2, 4, 5, 1};

      // Accessing an element in an array
      Console.WriteLine($"You rated the song {summerStrut[1]} {ratings[1]} stars.");

      // find the position for the first 3-star rated song and save it to a variable
      int threeStarIndex = Array.IndexOf(ratings, 3);

      // Print a message to the console, like “Song number X is rated three stars”
      Console.WriteLine($"Song number {threeStarIndex + 1} is rated three stars");

      // Find the first song that has more than 10 characters in its title. Save it to a variable and print a message to the console, such as “The first song that has more than 10 characters in the title is X.”
      string firstTenChar = Array.Find(summerStrut, item => item.Length > 10);
      Console.WriteLine($"The first song that has more than 10 characters in the title is {firstTenChar}.");

      // Organize the playlist alphabetically. To check that it worked, print the first and last song titles to the console.
      Array.Sort(summerStrut);
      Console.WriteLine(summerStrut[0]);
      Console.WriteLine(summerStrut[7]);

      // Copy your playlist to a new playlist called summerStrutCopy
      string[] summerStrutCopy = new string[8];
      Array.Copy(summerStrut, summerStrutCopy, 8);

      // Print the first value of summerStrutCopy to the playlist to see if is the same as summerStrut.
      Console.WriteLine(summerStrutCopy[0]);

      // Reverse the order of the summerStrut playlist
      Array.Reverse(summerStrut);

      // Check to see if it worked by printing the first and last songs to the console.
      Console.WriteLine(summerStrut[0]);
      Console.WriteLine(summerStrut[7]);

      // Turns every rating in the ratings array to zero
      Array.Clear(ratings, 0, 7);

      // Check to see if it worked by printing out the first value to the console (it should be to 0).
      Console.WriteLine(ratings[0]);
      
    }
  }
}