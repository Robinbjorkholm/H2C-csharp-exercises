using System;

namespace exercise_29
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("give first number");
      int first = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("give 2nd number");
      int second = Convert.ToInt32(Console.ReadLine());

        if(first>second)
        {
                Console.WriteLine("the larger number is " +first );
        } else if (first == second)
           {
                Console.WriteLine("the numbers are equal ");
           }
        else
            {
               Console.WriteLine("the larger number is "+second);
            }
        
    }
  }
}
