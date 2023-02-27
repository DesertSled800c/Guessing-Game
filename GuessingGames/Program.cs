using System;

Random r = new Random();
int SecretNum = r.Next(1, 100);

void NumberPrompt(string question, int secretNum)
{
    Console.Write(secretNum);
    for (int i = 0; i < 4; i++)
    {
        Console.WriteLine($"{question}");
        string answer = Console.ReadLine();
        int parsedAnswer = int.Parse(answer);
        if (parsedAnswer == secretNum)
        {
            Console.WriteLine("Correct Number");
            return;
        }
        else
        {
            if (parsedAnswer < secretNum)
            {
                Console.WriteLine("Too Low");
            }
            else
            {
                Console.WriteLine("Too High");
            }
            Console.WriteLine($"You have {4 - (i + 1)} guesses remaining");
        }
    }
}

NumberPrompt("Guess a Number", SecretNum);












