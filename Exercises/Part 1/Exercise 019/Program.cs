using System;

namespace exercise_19
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("enter first number");
      int i = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("enter 2nd number");
      int b = Convert.ToInt32(Console.ReadLine());
      int sum = (+i+b);
      Console.WriteLine("sum is " +i+ "+" +b+ "="   +sum);

    }
  }
}
