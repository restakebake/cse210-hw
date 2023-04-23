using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("What is your magic number? ");
        // string number = Console.ReadLine();

        Random randomGenerator = new Random ();
        int magic = randomGenerator.Next (1, 101);

        // int magic = int.Parse(number);
        int guess = -1;

        while (guess != magic)
        {
            Console.WriteLine("What is your guess? ");
            guess =  int.Parse(Console.ReadLine());

            
            if (guess > magic)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magic)
            {
                Console.WriteLine("Higher");
            }
            else 
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}