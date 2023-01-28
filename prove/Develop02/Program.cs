using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Hello Develop02 World!");
  }
  public class Job
  {
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;
    public void Display()
    {
      Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
  }
{
    static void Main(string[] args)

  //first job//
  {
    Job job1 = new Job();
    job1._jobTitle = "Cashier";
    job1._company = "Aerial";
    job1._startYear = 2019;
    job1._endYear = 2022;

    //second job//

    Job job2 = new Job();
    job2._jobTitle = "Secretary";
    job2._company = "Detol";
    job2._startYear = 2022;
    job2._endYear = 2023;
    Resume myResume = new Resume();
    myResume._name = "Kenslin Rohin";
    myResume._jobs.Add(job1);
    myResume._jobs.Add(job2);

    myResume.DisplayResumeDetails();
    myResume.Display();
  }
}
}