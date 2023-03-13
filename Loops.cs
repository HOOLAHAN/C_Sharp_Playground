using System;

namespace WhileLoop
{
  class Loops
  {
    static void Main(string[] args)
    {
      
      // While Loop :

      int emails = 20;

      // Write a while loop that checks to see if there are any emails in your inbox. If there are still emails, decrease the amount of emails by one until there are no emails left.
      while (emails > 0) 
      {
        Console.WriteLine(emails);
        Console.WriteLine("deleting an email");
        emails --;
      }
      Console.WriteLine("INBOX ZERO ACHIEVED!");

      // Do...While Loop : 
      // Similar to the while loop, a do...while loop will continue running until a stopping condition is met. 
      // One key difference is that no matter what, a do...while loop will always run once.

      bool buttonClick = true;
      
      do
      {
        Console.WriteLine("BLARRRRRRRRR");
      } while(!buttonClick);
      Console.WriteLine("Time for a five minute break.");

      // For Loop : 
      // Initialization: where the loop begins
      // Stopping condition: the condition that the iterator variable is evaluated against
      // Iteration statement: used to update the iterator variable on each loop
      // i.e.
      // for (initialization; stopping condition; iteration statement)
      // {
      //   statement;
      // }


    // Write a for loop that runs once for each week in your 16-week long project.
      for (int i = 0; i < 16; i++)
      {
        CreateTemplate(i + 1);
      }

    // For Each Loop : 
    // foreach (type element in sequence)
    // {
    //   statement;
    // }

      string[] todo = { "respond to email", "make wireframe", "program feature", "fix bugs" };

      // Write a loop that will iterate through each item in your todo array and call the CreateTodoItem() method 
      foreach (string item in todo)
      {
        CreateTodoItem(item);
      } 

    }

    static void CreateTemplate(int week)
    {
      Console.WriteLine($"Week {week}");
      Console.WriteLine("Announcements: \n \n \n ");
      Console.WriteLine("Report Backs: \n \n \n");
      Console.WriteLine("Discussion Items: \n \n \n");
    }

    static void CreateTodoItem(string item)
    {
      Console.WriteLine($"[] {item}");
    }
  }
}



// In general,

// while loops are good when you know your stopping condition, but not when you know how many times you want a program to loop or if you have a specific collection to loop through.

// do...while loops are only necessary if you definitely want something to run once, but then stop if a condition is met.

// for loops are best if you want something to run a specific number of times, rather than given a certain condition.

// foreach loops are the best way to loop over an array, or any other collection.


// CONTINUE, BREAK and RETURN:

// The continue keyword is used to bypass portions of code. It will ignore whatever comes after it in the loop and then will go back to the top and start the loop again.
// If you only want to break out of one loop and not exit a method, use break.
// You should only use return if you need to exit a method because it will break out of all loops. 

// SUMMARY :
// while loop: while(){..} 
// do...while loop: do{...}while();
// for loop: for(int i=0; i<x; i++){}
// foreach loop: foreach(int item in list){}
// jump statements: break, continue, return