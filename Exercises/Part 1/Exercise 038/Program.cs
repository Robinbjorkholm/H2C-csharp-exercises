using System;

namespace exercise_38
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("enter numbers");
      int [] numbers = new int [6];

      for(int i = 0;i < numbers.Length; i++)
      {
         Console.WriteLine("give a number");
         numbers[i] = Convert.ToInt32(Console.ReadLine());

        for(int i=0;i<numbers.length;i++)
        {
              if( numbers[i]<0)
                    Console.WriteLine("here are your negative numbers");

        }

     
      }
            
           



    }
  }
}
