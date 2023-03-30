class activities
{
  public virtual void workout()
  {
    DateOnly dateOnly = DateOnly.FromDateTime(DateTime.Now);
    Console.WriteLine("Enter the number of laps:  ");
    int laps = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter your length in minutes:  ");
    int minutes = Convert.ToInt32(Console.ReadLine());
    float distance = laps * 50 / 1000;
    float speed = (distance / minutes) * 60;
    float pace = minutes / distance;

    Console.WriteLine($"{dateOnly} Running ({minutes})min: Distance {distance}km, Speed: {speed}kph, Pace: {pace}min per km");
    Console.WriteLine($"{dateOnly} Cycling ({minutes})min: Distance {distance}km, Speed: {speed}kph, Pace: {pace}min per km");
    Console.WriteLine($"{dateOnly} Swimming ({minutes})min: Distance {distance}km, Speed: {speed}kph, Pace: {pace}min per km");




  }
}