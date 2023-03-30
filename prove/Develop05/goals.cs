using System;
using System.Collections.Generic;


public abstract class Goal
{
  public string Name;
  public int Points;

  public Goal(string name, int points)
  {
    Name = name;
    Points = points;
  }

  public abstract void RecordEvent();
  public abstract string GetStatus();
}


public class SimpleGoal : Goal
{
  public SimpleGoal(string name, int points) : base(name, points) { }

  public override void RecordEvent()
  {
    Console.WriteLine($"you have made it: {Name} (+{Points} points)");
  }

  public override string GetStatus()
  {
    return "[ ] " + Name;
  }
}

public class EternalGoal : Goal
{
  private int _count = 0;

  public EternalGoal(string name, int points) : base(name, points) { }

  public override void RecordEvent()
  {
    _count++;
    Console.WriteLine($"Recorded the goal progress: {Name} (+{Points} points)");
  }

  public override string GetStatus()
  {
    return $"{_count}x {Name}";
  }
}

public class ChecklistGoal : Goal
{
  private int _count = 0;
  private int _targetCount;

  public ChecklistGoal(string name, int points, int targetCount) : base(name, points)
  {
    _targetCount = targetCount;
  }

  public override void RecordEvent()
  {
    _count++;
    Console.WriteLine($"Recorded the goal progress: {Name} (+{Points} points)");

    if (_count == _targetCount)
    {
      Points += 500;
      Console.WriteLine($"you have made it: {Name} (+500 bonus points)");
    }
  }

  public override string GetStatus()
  {
    return $"Completed {_count}/{_targetCount} times: {Name}";
  }
}

// Define the main EternalQuest program class
public class EternalQuest
{
  private List<Goal> _goals = new List<Goal>();

  public void AddGoal(Goal goal)
  {
    _goals.Add(goal);
    Console.WriteLine($"Added goal: {goal.Name}");
  }

  public void RecordEvent(string name)
  {
    foreach (Goal goal in _goals)
    {
      if (goal.Name == name)
      {
        goal.RecordEvent();
        return;
      }
    }

    Console.WriteLine($"Goal not found: {name}");
  }

  public void DisplayStatus()
  {
    int totalPoints = 0;

    Console.WriteLine("Current Goals:");
    foreach (Goal goal in _goals)
    {
      Console.WriteLine(goal.GetStatus());
      totalPoints += goal.Points;
    }

    Console.WriteLine($"Total Points: {totalPoints}");
  }
}

// Demonstrate usage of the EternalQuest program
