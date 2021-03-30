using System;

namespace exercise_17
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("give first number");
      int i = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("give 2nd number");
      int a = Convert.ToInt32(Console.ReadLine());
      int sum = i + a;
            Console.WriteLine("the sum is " +sum);

    }
  }
}
