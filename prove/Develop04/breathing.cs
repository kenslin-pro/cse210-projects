public class Breathing : Activity
{
  public Breathing() : base()
  {
    _name = "Breathing";
    _duration = 0;
    _description = "This activity will help you relax by walking you through breathing in and out exercise in a guided set of time";
  }

  public void Breathe()
  {
    for (int i = 5; i >= 0; i--)
    {
      Console.Write($"\rBreathe in... {i}");
      Thread.Sleep(1200);
    }
    Console.WriteLine("");

    for (int j = 5; j >= 0; j--)
    {
      Console.Write($"\rNow breathe out... {j}");
      Thread.Sleep(1200);
    }

  }

  public void RunActivity()
  {
    GetDuration(_duration);
    DateTime currentTime = DateTime.Now;
    while (currentTime < _endTime)
    {
      Breathe();
      currentTime = DateTime.Now;
      Console.WriteLine("");

    }
  }
}

