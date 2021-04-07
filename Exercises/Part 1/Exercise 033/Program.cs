using System;

namespace exercise_33
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("enter a string");
      string i = Console.ReadLine();
       Console.WriteLine("enter another string");
       string b = Console.ReadLine();

        if(i == b)
        {
         Console.WriteLine("echo");   
        }else
            {
                Console.WriteLine("Nope");
            }

    }
  }
}
