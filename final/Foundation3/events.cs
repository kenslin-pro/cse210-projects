class events
{
  public void welcome()
  {
    Console.WriteLine("WELCOME TO OUR EVENT!!!\n");
  }
  public void date()
  {
    DateOnly dateOnly = DateOnly.FromDateTime(DateTime.Now);
    TimeOnly timeOnly = TimeOnly.FromDateTime(DateTime.Now);

    Console.WriteLine($"The event will take place on: {dateOnly}\n");
    Console.WriteLine($"The event will start at: {timeOnly}\n");
  }

}