using System;

namespace exercise_48
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("write numbers");
      int a = -1;
      int i = Convert.ToInt32(Console.ReadLine());
      int sum = 0;
      int b = 0;
      int e = 1;
      int even = 0;
      int odd = 0;
                
       for(int c = 0;i > a;b++)
       {
          sum += + i;
          i = Convert.ToInt32(Console.ReadLine());
           if(i % 2 == 0)
           {
              even++;  
           }   
              else
              {
              odd++;
              }  
       }
      
        int avg = sum/b;   
        int counter = b;
        Console.WriteLine("thx!bye!");
        Console.WriteLine("you entered " +counter+ " numbers");
        Console.WriteLine("your sum is " +sum);
        Console.WriteLine("your average is "+avg);
        Console.WriteLine("amount of even numbers are "+even);
        Console.WriteLine("amount of odd numbers are "+odd);
    }
  }
}
