class Program
{
  static void Main(string[] args)
  {
    int option = 0;

    while (option != 4)
    {
      Console.Clear();
      Console.WriteLine("Welcome To The Mindfulness Program");
      Console.WriteLine("MENU OPTIONS");
      Console.WriteLine("1. Breathing Activity");
      Console.WriteLine("2. Reflecting Activity");
      Console.WriteLine("3. Listing Activity");
      Console.WriteLine("4. Quit");
      option = int.Parse(Console.ReadLine());
      Console.Clear();

      if (option == 1)
      {
        Breathing breathing = new Breathing();
        breathing.StartMessage();
        breathing.RunActivity();
        breathing.EndMessage();

      }

      else if (option == 2)
      {
        Listing listing = new Listing();
        listing.StartMessage();
        listing.RunActivity();
        listing.EndMessage();
      }

      else if (option == 3)
      {
        Reflecting reflecting = new Reflecting();
        reflecting.StartMessage();
        reflecting.RunActivity();
        reflecting.EndMessage();
      }

      else
      {
        Console.WriteLine("Thanks for visiting the Mindfulness program");
        break;
      }
    }
  }
}