using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Demo
{
   public class Program
    {
        static void Main(string[] args)
        {
            string input = "" ;
            int number = 0;
            bool repeat = true;
            string command = "Enter Number from 1 to 5";
            Random random = new Random();
            int randomNumber = random.Next(1, 5);

            while (repeat == true)
             { 
               Console.WriteLine(command);
               input = Console.ReadLine();

            try
             {
                number = Int32.Parse(input);
                if (number == randomNumber)
                {
                    Console.WriteLine("Correct");
                    Console.Read();
                    repeat = false;
                }
                else
                {
                    Console.WriteLine(input + " is not a correct answer. Please try again");
                }
             }
            catch
             {
                 Console.WriteLine("Input string is not number");
                 repeat =  true;
             }

          } 
        }
    }   
}
