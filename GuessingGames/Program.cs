using System;

Random r = new Random();
int SecretNum = r.Next(1, 100);

NumOfPrompts();

void TheGame(string question, int secretNum, int numOfPrompts)
{
    Console.WriteLine(secretNum);
    Console.WriteLine("");
    if (numOfPrompts == -1)
    {
        while (true)
        {
            Console.WriteLine($"{question}");
            string answer = Console.ReadLine();
            int parsedAnswer = int.Parse(answer);
            if (parsedAnswer == secretNum)
            {
                Console.WriteLine("YOU WIN");
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
                Console.WriteLine("");
            }
        }
    }
    else
    {
        for (int i = 0; i < numOfPrompts; i++)
        {
            Console.WriteLine($"{question}");
            int answer = int.Parse(Console.ReadLine());
            if (answer == secretNum)
            {
                Console.WriteLine("YOU WIN");
                return;
            }
            else
            {
                if (answer < secretNum)
                {
                    Console.WriteLine("Too Low");
                }
                else
                {
                    Console.WriteLine("Too High");
                }
                Console.WriteLine("");
                Console.WriteLine($"You have {numOfPrompts - (i + 1)} guesses remaining");
            }
        }
    }
}

void NumOfPrompts()
{
    Console.WriteLine($"What difficulty level would you like to play? (Easy | Medium | Hard | Cheater):");
    string difficulty = Console.ReadLine().ToLower();
    Console.WriteLine($"Then {difficulty.ToUpper()} you will get.");
    Console.WriteLine("");
    if (difficulty == "easy")
    {
        TheGame("Guess a Number??", SecretNum, 8);
    }
    else if (difficulty == "medium")
    {
        TheGame("Guess a Number??", SecretNum, 6);
    }
    else if (difficulty == "hard")
    {
        TheGame("Guess a Number??", SecretNum, 4);
    }
    else if (difficulty == "cheater")
    {
        TheGame("Guess a Number??", SecretNum, -1);
    }
    else
    {
        Console.WriteLine("No such category, check you spelling!!");
    }
}


