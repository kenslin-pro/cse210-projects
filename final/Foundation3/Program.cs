using System;

class Program
{
  static void Main(string[] args)
  {

    //outdoor event
    outdoor outdoor = new outdoor();
    outdoor.welcome();
    outdoor.tittle();
    outdoor.date();
    outdoor.Discription();
    addresses addresses = new addresses();
    addresses.address1();

    //receptions event
    receptions receptions = new receptions();
    receptions.welcome();
    outdoor.tittle();
    receptions.date();
    receptions.Discription();
    addresses.address3();

    //lecture event
    lecture lecture = new lecture();
    lecture.welcome();
    lecture.tittle();
    lecture.date();
    lecture.Discription();
    addresses.address2();
  }
}