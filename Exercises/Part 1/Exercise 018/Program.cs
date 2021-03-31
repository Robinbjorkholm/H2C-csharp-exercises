using System;

namespace exercise_18
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("enter first number");
       int i = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("enter 2nd number");
        int a = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("enter 3rd number");
        int c = Convert.ToInt32(Console.ReadLine());
        int sum = (i + a + c);
        Console.WriteLine("the sum is " +sum);
    }
  }
}
