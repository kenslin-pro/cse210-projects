public class Listing : Activity
{

  public Listing() : base()
  {
    _name = "Listing";
    _duration = 0;
    _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
  }

  public string GetRandomPrompt()
  {
    List<string> prompts = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "When have you felt the Holy Ghost this month?"
        };
    Random random = new Random();
    int index = random.Next(prompts.Count);
    string randPrompt = prompts[index];
    prompts.Remove(randPrompt);
    return randPrompt;

  }

  public void DisplayRandomPrompt()
  {
    string randPrompt = GetRandomPrompt();
    Console.WriteLine(randPrompt);
  }

  public void RunActivity()
  {
    int items = 0;
    GetDuration(_duration);
    DisplayRandomPrompt();
    DateTime currentTime = DateTime.Now;
    while (currentTime < _endTime)
    {
      Console.Write(">");
      Console.ReadLine();
      items += 1;
      currentTime = DateTime.Now;

    }
    Console.WriteLine($"You listed {items} items!");
  }
}

