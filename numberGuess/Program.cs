using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            int rounds = 10;
            int randomNumber = new Random().Next(100) + 1;
            int enteredNumber = 0;


            while (rounds > 0)
            {
                Console.WriteLine("Guess the number ");
                enteredNumber = Convert.ToInt32(Console.ReadLine());

                if (enteredNumber > randomNumber)
                {
                    Console.WriteLine("Please enter a smaller number");
                }
                else if (enteredNumber < randomNumber)
                {
                    Console.WriteLine("Please enter a bigger number");
                }
                else
                {
                    Console.WriteLine("Congratulations! You win");
                    Console.ReadLine();
                    return;

                }
           
            }

            Console.WriteLine("You lose");
            Console.ReadLine();


        }
    }
}
