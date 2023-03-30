public class Reflecting : Activity
{

  public Reflecting() : base()
  {
    _name = "Reflecting";
    _duration = 0;
    _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

  }

  public string GetRandomPrompt()
  {
    List<string> prompts = new List<string>()
        {
            "Think of a time when you last overcame a temptation.",
            "Think of a time when you did something you didnt want to do.",
            "Think of a time when you served somebody.",
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
  public string GetRandomQuestion()
  {
    List<string> questions = new List<string>()
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?"
        };
    Random random = new Random();
    int index = random.Next(questions.Count);
    string randQuest = questions[index];
    questions.Remove(randQuest);
    return randQuest;
  }

  public void DisplayRandomQuestion()
  {
    string randQuest = GetRandomQuestion();
    Console.WriteLine(randQuest);
  }

  public void RunActivity()
  {
    Console.WriteLine("Please consider the following prompt" + "\n" + "and then press enter once you have given yourself enough time to consider:");
    Console.WriteLine("");

    DisplayRandomPrompt();
    Console.ReadLine();
    Console.Clear();

    Console.WriteLine("Since you have an experience in mind, answer the questions to help you reflect on your experience: ");
    Console.WriteLine("");
    Console.Clear();

    for (int i = 5; i > 0; i--)
    {
      Console.Write($"Delivering questions in {i} seconds.");
      Thread.Sleep(1000);
      Console.Clear();
    }

    Console.Clear();

    GetDuration(_duration);
    DateTime currentTime = DateTime.Now;
    while (currentTime < _endTime)
    {
      Console.Write(">");
      DisplayRandomQuestion();
      GetSpinner();
      currentTime = DateTime.Now;
      Console.WriteLine("");
    }

  }
}