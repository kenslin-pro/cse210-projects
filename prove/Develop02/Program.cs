using System;


class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Hello Develop02 World!");
    // the options that user can choose
    {
      string journal = new Journal();
      while (true)
      {
        Console.Write("Choose one from the following");
        Console.WriteLine();
        Console.WriteLine("1. write new entry");
        Console.WriteLine("2. Display the journal");
        Console.WriteLine("3. Load the journal from a  file");
        Console.WriteLine("4. Save the journal to a file");
        Console.WriteLine("5. Quit");
        Console.Write("Please enter what you would like to do. ");
        int choice = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
          Entry newEntry = new Entry();
          newEntry._prompt = GetRandomPrompt();
          Console.WriteLine(newEntry._prompt);
          Console.WriteLine('>' + newEntry._prompt);
          newEntry._response = Console.ReadLine();
          DateTime theCurrentTime = DateTime.Now;
          newEntry._date = theCurrentTime.ToShortDateString();
          journal._entries.Add(newEntry);

          //The use of if statement

        }
        else if (choice == 2)
        {
          journal.Display();
        }
        else if (choice == 3)
        {
          Console.Write("Type the name of the file: ");
          journal._filename = Console.ReadLine();
          journal.LoadFile();
        }
        else if (choice == 4)
        {
          Console.Write("Type the name of the file");
          Console.Write("Enter file name ");
          journal._filename = Console.ReadLine();
          journal.SaveFile();
        }
        else if (choice == 5)
        {
          break;
        }
        // list of random options

      }
      static string GetRandomPrompt()
      {
        List<string> prompts = new List<string>()
            {
                "Who was the most interesting person I interacted with today?",
                "What was the best part of my day?",
                "How did I see the hand of the Lord in my life today?",
                "What was the strongest emotion I felt today?",
                "If I had one thing I could do over today, what would it be?"
            };
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];

        // date and time

      }
      public class Entry
  {
    public string _date = "";
    public string _prompt = "";
    public string _response = "";
    public void Format()
    {
      Console.WriteLine($"Date: {_date} - prompt: {_prompt}\n{_response} ");
      Console.WriteLine();
    }
  }
}


  }
}
