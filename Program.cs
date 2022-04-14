using System;

namespace GuessingGameThreeTries
{ 
    class Program
    
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int myRandom = rnd.Next(1, 11);
            int counter = 3;
            Console.WriteLine("Try to guess my number! It is from 0 to 10 only! But remember, ytou have three tries only!");
            

            while (counter > 0)
            {

                int answer = Convert.ToInt32(Console.ReadLine());
                if (answer == myRandom)
                {
                    Console.WriteLine($"You are right, the answer is {answer}!");
                    break;
                }
                else
                {
                    --counter;
                    Console.WriteLine($"WRONG! {counter} tries left!");
                }
            }


        }

    }
}
