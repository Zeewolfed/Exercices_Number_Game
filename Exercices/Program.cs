
using System;
using System.Runtime.InteropServices;
using System.Xml.Schema;

namespace exercices
{
    internal class Program
    {
        static int nombre()
        {
            Random dice = new Random();

            int roll = dice.Next(1, 7);
            int roll1 = dice.Next(1, 7);
            int roll2 = dice.Next(1, 7);

            int result = roll + roll1 + roll2;

            Console.WriteLine($"Dice {roll} + {roll1} + {roll2} = {result}");

            
            if ((roll == roll1) || (roll1 == roll2) || (roll2 == roll))
            {
                if ((roll == roll1) && (roll1 == roll2))
                {

                 Console.WriteLine("You rolled triples ! so you get +6 bonus to total");
                    result += 6;
                }
                else
                {
                    Console.WriteLine("You roll doubles ! so you get +2 bonus to total! ");
                    result += 2;
                } 

            }           
            if (result >= 16)
            {
                Console.WriteLine("You won a car!");
            }
            else if (result >= 10)
            {
                Console.WriteLine("You won a laptop!");
            }
            else if(result == 7)
            {
                Console.WriteLine("You won a trip for two!");
            }
            else
            {
                Console.WriteLine("You wan a Kitten!hiphiphip");
            }

            return result;
        }
        

        static void Main(string[] args)
        {

            int resultat = nombre();

            

        }
    }
}


