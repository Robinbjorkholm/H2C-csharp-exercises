using System;

namespace exercise_22
{
  class Program
  {
    public static void Main(string[] args)
    {

       Console.WriteLine("enter a number");
        double i = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("enter a 2nd number");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("enter a 3rd number");
        double c = Convert.ToDouble(Console.ReadLine());
        double a = 3;
        double sum = i+b+c;
        double avg = (sum/a);
            Console.WriteLine(avg);

    }
  }
}
