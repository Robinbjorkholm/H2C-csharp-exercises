using System;

namespace exercise_47
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("where to?");
            int i = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("where from?");
       
       
        for(int a = Convert.ToInt32(Console.ReadLine()); a <= i;a++)
        {
         Console.WriteLine(+a);
        }
    }
  }
}
