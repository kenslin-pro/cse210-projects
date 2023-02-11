using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Hello Prep2 World!!!!!!");
    Console.Write("What is your grade percent");
    string answer = Console.ReadLine();
    int percent = int.Parse(answer);
    string letter = "";
    if (percent >= 90)

    {
      letter = "A";
    }
    else if (percent >= 80)

    {
      letter = "B";
    }
    else if (percent >= 70)

    {
      letter = "C";
    }
    else if (percent >= 60)

    {
      letter = "D";
    }
    else

    {
      letter = "F";
    }
    Console.WriteLine($"Your grade is: {letter}");

    if (percent >= 70)
    {
      Console.WriteLine("You passed!");
    }
    else
    {
      Console.WriteLine("Better luck next time!");
    }
    string strz = "This is me";
    string upperstrz = strz.ToUpper();
    Console.WriteLine(upperstrz);
    string str = "kenslin";
    int index1 = str.IndexOf("s");
    Console.WriteLine($"the index is{index1}");

    int a = 20;
    a++;
    {
      Console.WriteLine(a);
    }
    string value = "Do Not pass";
    char first = value[0];
    {
      Console.WriteLine(first);
    }
  }
}