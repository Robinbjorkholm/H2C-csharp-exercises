using System;

namespace exercise_37
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("enter numbers");
          
      int[] numbers  = new int[3]; // how do i put a random sized array? so i just can fill it up as much as i want, so it only stops when i enter a 0
       
      
      
           
         for ( int i = 0; i < numbers.Length;i++)
         {
              numbers[i] = Convert.ToInt32(Console.ReadLine());
                if (numbers[i] < 0)
                {
                Console.WriteLine("total amount of numbers");
                Console.WriteLine(numbers.Length);
                }
         }
            
            
         
                
              
             
         

    }
  }
}
