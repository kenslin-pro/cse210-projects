public class ListingActivity : Activity
{
  // The list of prompts
  public List<string> Prompts { get; set; }

  public override void RunActivity()
  {

    Console.WriteLine($"Starting {Name} which will last for {Duration} seconds.");
    Console.WriteLine($"Description: {Description}");
    Console.WriteLine("Prepare to begin...");

    // Pause calculation
    System.Threading.Thread.Sleep(3000);
    Random random = new Random();
    int promptIndex = random.Next(0, Prompts.Count - 1);
    Console.WriteLine(Prompts[promptIndex]);
    System.Threading.Thread.Sleep(Duration * 1000);

    Console.WriteLine("Start listing...");
    int itemCount = 0;
    while (Duration > 0)
    {
      string input = Console.ReadLine();
      itemCount++;
      Duration--;
    }

    Console.WriteLine("Great job!");
    Console.WriteLine($"You have completed the {Name} activity for {Duration} seconds and listed {itemCount} items.");
    Console.WriteLine("I appretiate your participation.");
  }
}

