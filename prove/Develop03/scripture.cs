using System;
using System.Collections.Generic;
using System.Linq;

class program

{

  static void Main()

  {

    //  t he new scripture

    Scripture scripture = new Scripture("Mathew 4:6", "For he will command his angels concerning you. to guard you in all your ways; they will lift you up in their hands, so that you will not strike your foot against a stone.");

    // display the full scripture

    Console.Clear();

    scripture.DisplayScripture();

    while (true)

    {

      Console.WriteLine("Press enter to hide a word or type quit to exit:");
      string userInput = Console.ReadLine();

      // quit the program

      if (userInput.ToLower() == "quit")

      {

        break;

      }

      else

      {

        // Clear the console and hide words in the scripture

        Console.Clear();

        scripture.HideWord();

        scripture.DisplayScripture();
        // Check if all the hidden words

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
    // Display the scripture

    Console.WriteLine(reference);
    string[] words = text.Split(' ');
    foreach (string word in words)
    {

      // Check hidden words
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
    string[] words = text.Split(' ');
    Random rand = new Random();
    int index = rand.Next(words.Length);
    string wordToHide = words[index];
    hiddenWords.Add(wordToHide);
  }
  public bool AllWordsHidden()
  {
    string[] words = text.Split(' ');
    return hiddenWords.Count == words.Length;
  }

}

