
using System;

namespace exercise_30
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("give me your percent[0-100]");
      int percent = Convert.ToInt32(Console.ReadLine());
            if(percent <= 0 )
            {
             Console.WriteLine("impossible");
            }

            if(percent > 0 && percent <= 49)
            {
            Console.WriteLine("fail");
            }

            if(percent >= 50 && percent <= 59)
            {
                Console.WriteLine("your grade is 1");            
            }
            if(percent >= 60 && percent <= 69)
            {
                Console.WriteLine("your grade is 2 ");            
            }
            if(percent >= 70 && percent <= 79)
            {
                Console.WriteLine("your grade is 3");           
            }

            if(percent >= 80 && percent <= 89)
            {
              Console.WriteLine("your grade is 4");            
            }
            if(percent >=90 && percent <=100)
            {
            Console.WriteLine("your grade is 5");
            }
            if(percent > 100)
            {
              Console.WriteLine("outstanding!");            
            }

      
    }       
                
           
  }
}
