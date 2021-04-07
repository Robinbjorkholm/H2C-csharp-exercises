using System;

namespace exercise_32
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("enter a string");
      string i = Console.ReadLine();
      string b = "Mellon";
            // is it possible to not make it uppercase sensitive?
           if(b == i)
            {
                Console.WriteLine("welcome, friend");
            }else
            {
                Console.WriteLine("they've got a cave troll!!");
            }
           

    }
  }
}
