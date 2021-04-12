using System;

namespace exercise_45
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("enter a integer");

      int i = Convert.ToInt32(Console.ReadLine());
      int a=0;
      for(a = 0;a < i;a++)
            {
              Console.WriteLine(+a);
            }
    }
  }
}
