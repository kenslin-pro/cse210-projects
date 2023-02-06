using System;
public class Journal

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Hello Develop02 World!");

        public string _filename = "";
  public List<Entry> _entries = new List<Entry>();
  public void Display()
  {
    foreach (Entry entry in _entries)
    {
      entry.Format();
    }
  }
  public void SaveFile()
  {
    using (StreamWriter outputFile = new StreamWriter(_filename))
    {
      foreach (Entry entry in _entries)
      {
        outputFile.WriteLine($"{entry._date}  , {entry._prompt} , {entry._response}");
      }
    }
  }
  public void LoadFile()
  {
    string[] lines = System.IO.File.ReadAllLines(_filename);
    foreach (string line in lines)
    {
      string[] parts = line.Split(",");
      Entry oldEntry = new Entry();
      pastEntry._date = parts[0];
      pastEntry._prompt = parts[1];
      pastEntry._response = parts[2];
      _entries.Add(pastEntry);
    }

  }

}