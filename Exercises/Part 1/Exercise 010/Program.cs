using System;

namespace exercise_10
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("I will tell a story, but I need some information");
            Console.WriteLine("please enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("please enter you profession");
            string profession = Console.ReadLine();
            Console.WriteLine("Here is the story!");
            Console.WriteLine("Once upon a time there was a " +profession+ " called " +name+" on his way to work\n"+name+" often wondered what being a "+profession+" meant to them.");
            Console.WriteLine("when you work as a "+profession+" you meet interesting people.\n"+name+" enjoys his work "+profession+" the end.");
            

              
             
           
            


        }
    }
}
