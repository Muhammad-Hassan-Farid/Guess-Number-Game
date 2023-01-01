using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{


     class Program
    {
       
        static void Main(string[] args)
        {
            Console.Write("What is your Name: ");
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, Let's Play.",inputName);


           while(true)
            {
                Random randomNumber = new Random();

                int correctNumber = randomNumber.Next(1, 10);
                int guess = 0;

                while (guess != correctNumber)
                {
                    Console.Write("Guess a Number B/W 1 to 10: ");
                    string input = Console.ReadLine();


                    if (!int.TryParse(input, out guess))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You enter the wrong number. Try Again....");
                        Console.ResetColor();
                        continue;
                    }

                    guess = Int32.Parse(input);

                    if (guess == correctNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Wow, your answere is correct.");


                    }
                    else if (guess != correctNumber) 
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Your answere is wrong.Try Again....");

                    }

                    Console.ResetColor();

                }
                
                Console.Write("Do you want to continue [Y/N]: ");
                string answere = Console.ReadLine().ToUpper();

                if(answere=="Y")
                {
                    continue;
                }
                else if(answere=="N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
            Console.ReadLine();

        }
    }
}
