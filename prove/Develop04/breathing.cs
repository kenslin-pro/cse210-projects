public class BreathingActivity : Activity
{
  public override void RunActivity()
  {
    Console.WriteLine($"Starting {Name} which will last for {Duration} seconds.");
    Console.WriteLine($"Description: {Description}");
    Console.WriteLine("Prepare to begin...");
    System.Threading.Thread.Sleep(3500);

    Console.WriteLine("Inhale...");
    System.Threading.Thread.Sleep(Duration * 1200);
    Console.WriteLine("Exhale...");
    System.Threading.Thread.Sleep(Duration * 1200);

    Console.WriteLine("Good job!");
    Console.WriteLine($"You have completed the {Name} activity for {Duration} seconds.");
    Console.WriteLine("Thank you for participating.");
  }
}


