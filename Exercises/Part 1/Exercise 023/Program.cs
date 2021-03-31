using System;

namespace exercise_23
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("enter a number");
        double i = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("enter a 2nd number");
        double a = Convert.ToDouble(Console.ReadLine());
       double sum = (i+a);
       double sub =(i-a);
       double mult =(i*a);
        int b = 2;
        double avg = (sum/b);

        Console.WriteLine("your sum is "+i+"+"+a+"=" +sum);
        Console.WriteLine("your sub is "+i+"-"+a+"=" + sub);
        Console.WriteLine("your product is "+i+"*"+a+"=" +mult);
        Console.WriteLine("your average is "+i+"+"+a+"/2=" +avg);

    }
  }
}
