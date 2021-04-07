using System;

namespace exercise_31
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("enter a number");
        int i = Convert.ToInt32(Console.ReadLine());
        int a = 2;
            if(i % a ==0)
            {
                Console.WriteLine("the number is even");       
            }else
            {
                Console.WriteLine("the number is  odd");
            }




    }
  }
}
