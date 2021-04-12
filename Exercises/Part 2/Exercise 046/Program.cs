using System;

namespace exercise_46
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine(" enter a number under 100");
      int i = Convert.ToInt32(Console.ReadLine());
      int a = 100;

      for(a=100;i <= a;i++)
            {
            Console.WriteLine(+i);
            }

    }
  }
}
