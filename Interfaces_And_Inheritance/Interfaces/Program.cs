using System;

namespace LearnInterfaces
{
  class Program
  {
    static void Main(string[] args)
    {
      Sedan s = new Sedan(60);
      Sedan z = new Sedan(70);
      Truck t = new Truck(45, 500);

      Console.WriteLine($"The first Sedan has speed { s.Speed }, {s.Wheels } wheels and a {s.LicensePlate} licence plate");
      Console.WriteLine($"The second Sedan has speed { z.Speed }, {z.Wheels } wheels and a {z.LicensePlate} licence plate");
      Console.WriteLine($"The truck has speed { t.Speed }, {t.Wheels } wheels and a {t.LicensePlate} licence plate");
    
      s.SpeedUp();
      z.SpeedUp();
      t.SpeedUp();
    
      Console.WriteLine($"The first Sedan has speed { s.Speed }, {s.Wheels } wheels and a {s.LicensePlate} licence plate");
      Console.WriteLine($"The second Sedan has speed { z.Speed }, {z.Wheels } wheels and a {z.LicensePlate} licence plate");
      Console.WriteLine($"The truck has speed { t.Speed }, {t.Wheels } wheels and a {t.LicensePlate} licence plate");

    }
  }
}