using System;

class Program
{


  static void Main(string[] args)
  {
    Console.WriteLine("Hello Develop03 World!");
  }
  string scripture = newScripture(" Mathew 4:6;For he will command his angels concerning you. to guard you in all your ways; they will lift you up in their hands, so that you will not strike your foot against a stone..");

  Console.Clear();

scripture.DisplayScripture();

while (true)


{

    Console.WriteLine("Type quit to exit");
    
    string userInput = Console.ReadLine();


    if (userInput.ToLower() == "quit")


}
{

}
else
{
  // Clear the console screen and hide a random word in the scripture

  Console.Clear();

  scripture.HideWord();

  scripture.DisplayScripture();

  if (scripture.AllWordsHidden())

    Console.WriteLine("Great,the scripture has been memorized!");
}
break;
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

    Console.WriteLine(reference);

    string[] words = text.Split(' ');

    foreach (string word in words)

    {

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

