using System;

Random r = new Random();
int SecretNum = r.Next(1, 100);

NumOfPrompts();

void NumberPrompt(string question, int secretNum, int numOfPrompts)
{
    Console.WriteLine(secretNum);
    Console.WriteLine("");
    for (int i = 0; i < numOfPrompts; i++)
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
            Console.WriteLine($"You have {numOfPrompts - (i + 1)} guesses remaining");
        }
    }
}

void NumOfPrompts()
{
    Console.WriteLine($"What difficulty level would you like to play? (Easy | Medium | Hard):");
    string difficulty = Console.ReadLine().ToLower();
    Console.WriteLine($"Then {difficulty.ToUpper()} you will get.");
    Console.WriteLine("");
    if (difficulty == "easy")
    {
        NumberPrompt("Guess a Number??", SecretNum, 8);
    }
    else if (difficulty == "medium")
    {
        NumberPrompt("Guess a Number??", SecretNum, 6);
    }
    else if (difficulty == "hard")
    {
        NumberPrompt("Guess a Number??", SecretNum, 4);
    }
    else
    {
        Console.WriteLine("No such category, check you spelling!!");
    }
}








