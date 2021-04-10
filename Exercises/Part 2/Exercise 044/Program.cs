using System;

namespace exercise_44
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("enter 2 integers");
     int i = Convert.ToInt32(Console.ReadLine());
     int a = Convert.ToInt32(Console.ReadLine());
    
     if(i > a)
     {
         Console.WriteLine(i+" is greater than " +a);   
     }
            else if(i == a)
            {   
            Console.WriteLine(i+" is equal to " +a);
            }
         else if(i<a)
            {
                Console.WriteLine(i+ " is less than " +a);
            }
         
    }
  }
}
