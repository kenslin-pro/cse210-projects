using System;



using System.Collections.Generic;



using System.Linq;





class Program



{



  static void Main()



  {



    // Create a new scripture



    Scripture scripture = new Scripture("Mathew 4:6", "For he will command his angels concerning you. to guard you in all your ways; they will lift you up in their hands, so that you will not strike your foot against a stone.");





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



          Console.WriteLine("You have done an amazing job by memorizing the scripture");



          break;



        }



      }



    }



  }



}





class Scripture



{



  private string reference;



  private string text;



  private List<string> hiddenWords;





  public Scripture(string reference, string text)



  {



    this.reference = reference;



    this.text = text;



    this.hiddenWords = new List<string>();



  }





  public void DisplayScripture()



  {



    // Display the reference and text of the scripture



    Console.WriteLine(reference);



    string[] words = text.Split(' ');



    foreach (string word in words)



    {



      // Check if the word is hidden



      if (hiddenWords.Contains(word))



      {



        Console.Write("_____ ");



      }



      else



      {



        Console.Write(word + " ");



      }



    }



    Console.WriteLine();



  }





  public void HideWord()



  {



    // Select a random word from the scripture text



    string[] words = text.Split(' ');



    Random rand = new Random();



    int index = rand.Next(words.Length);



    string wordToHide = words[index];





    // Add the word to the list of hidden words



    hiddenWords.Add(wordToHide);



  }





  public bool AllWordsHidden()



  {



    // Check if all words in the scripture text are in the list of hidden words



    string[] words = text.Split(' ');



    return hiddenWords.Count == words.Length;



  }



}

