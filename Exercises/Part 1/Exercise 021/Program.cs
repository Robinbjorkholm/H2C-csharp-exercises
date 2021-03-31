using System;

namespace exercise_21
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("enter a number");
        double i = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("enter a 2nd number");
        double b = Convert.ToDouble(Console.ReadLine());
        double a = 2;
        double sum = i+b;
        double avg = (sum/a);
            Console.WriteLine(avg);
    }
  }
}
