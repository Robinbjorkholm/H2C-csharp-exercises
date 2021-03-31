using System;

namespace exercise_26
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("how old are you?");
            int age = Convert.ToInt32(Console.ReadLine());
            int limit = 1900;

            if(age<1900)
            {
              Console.WriteLine("you are old");

            }

    }
  }
}
