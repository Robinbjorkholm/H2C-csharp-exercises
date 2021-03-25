using System;

namespace exercise_15
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("give me a string");
      string me = Console.ReadLine();
      Console.WriteLine(""+me);


      Console.WriteLine("give me an integer");
      int i = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine(""+i);


      Console.WriteLine("give me a double");
      string o = Console.ReadLine();
      double doublevalue = Convert.ToDouble(o);
      Console.WriteLine(""+o);

      Console.WriteLine("give me a boolean");
      bool truth = Convert.ToBoolean(Console.ReadLine());

        if ( truth)
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
