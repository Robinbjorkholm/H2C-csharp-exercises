using System;

namespace exercise_14
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give me the truth!");
        bool truth = Convert.ToBoolean(Console.ReadLine());
        
       if (truth)
        
        {
         Console.WriteLine("true");  
        }
      else
      {
          Console.WriteLine("false");        
      }

    }
  }
}
