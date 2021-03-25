using System;

namespace exercise_16
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("how many days");
      int i = Convert.ToInt32(Console.ReadLine());

      int s = 86400;
            
        Console.WriteLine(s * i);
    }
  }
}
