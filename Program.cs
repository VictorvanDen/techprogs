using System;

namespace z1
{
  class Program
  {
    static void Main(string[] args)
    {
      int y, t, u;
      y = Convert.ToInt32(Console.ReadLine());
      t = Convert.ToInt32(Console.ReadLine());
      u = t + y;
      Console.WriteLine(Convert.ToString(u));
      u = t * y;
      Console.WriteLine(Convert.ToString(u));
      u = y - t;
      Console.WriteLine(Convert.ToString(u));
      u = y / t;
      Console.WriteLine(Convert.ToString(u));
      u = y % t;
      Console.WriteLine(Convert.ToString(u));
      Console.WriteLine("Hello World!");
    }
  }
}
