using System;

namespace exercise_20
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("enter a number");
        int i = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("enter a 2nd number");
        int a = Convert.ToInt32(Console.ReadLine());
        int mult = (i*a);
        Console.WriteLine(mult);

    }
  }
}
