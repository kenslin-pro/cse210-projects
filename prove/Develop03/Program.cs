using System;



using System.Collections.Generic;



using System.Linq;





public class Program



{



  static void Main()



  {



    // Create a new scripture



    Scripture scripture = new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");





    // Clear the console screen and display the complete scripture



    Console.Clear();



    scripture.DisplayScripture();





    // Prompt the user to press enter or type quit



    while (true)



    {



      Console.WriteLine("Press enter to hide a word or type quit to exit:");



      string userInput = Console.ReadLine();





      // If the user types quit, end the program



      if (userInput.ToLower() == "quit")



      {



        break;



      }



      else



      {



        // Clear the console screen and hide a random word in the scripture



        Console.Clear();



        scripture.HideWord();



        scripture.DisplayScripture();





        // Check if all words have been hidden



        if (scripture.AllWordsHidden())



        {



          Console.WriteLine("Congratulations, you have memorized the scripture!");



          break;



        }



      }



    }



  }



}



