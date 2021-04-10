using System;

namespace exercise_42
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("enter 2 integers");
      int i = Convert.ToInt32(Console.ReadLine());
      int b = Convert.ToInt32(Console.ReadLine());
      int a = i+b;
      double square = Math.Sqrt(a);
            Console.WriteLine(square);
    }
  }
}
