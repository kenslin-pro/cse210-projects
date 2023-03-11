using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Hello Develop05 World!");
  }
  public static void Main()
  {
    EternalQuest quest = new EternalQuest();


    quest.AddGoal(new SimpleGoal("Did jogging", 1000));
    quest.AddGoal(new EternalGoal("Read Bible", 100));
    quest.AddGoal(new ChecklistGoal("Attend Temple", 50, 10));


    quest.RecordEvent("Read Bible");
    quest.RecordEvent("Read Bible");
    quest.RecordEvent("Attend Temple");
    quest.RecordEvent("Attend Temple");
    quest.RecordEvent("Attend Temple");
    quest.RecordEvent("Attend Temple");
    quest.RecordEvent("Attend Temple");
    quest.RecordEvent("Attend Temple");

    quest.DisplayStatus();
  }

}