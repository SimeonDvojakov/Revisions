using Rock_Paper_Scissors;

int userInputParsed = 0;

while (true)
{
    Console.WriteLine("Choose: Rock, Paper or scissors? (1,2,3)");
    try
    {
        userInputParsed = int.Parse(Console.ReadLine());
        if (userInputParsed > 3 || userInputParsed < 1)
        {
            throw new Exception();
        }
    }
    catch
    {
        Console.Clear();
        Console.WriteLine("Invalid input, try agian");
        continue;
    }

    int aIInput = new Random().Next(1, 4);
    Choices userChoice = (Choices)userInputParsed;
    Choices aIChoice = (Choices)aIInput;

    if (userChoice == aIChoice)
    {
        Console.WriteLine($"It's a tie, both players chose {userChoice}, try again? (Y/N)");
    }
    else if (userChoice == Choices.Rock && aIChoice == Choices.Scissors)
    {
        Console.WriteLine($"User chose {userChoice}");
        Console.WriteLine($"Opponent chose {aIChoice}");
        Console.WriteLine("User wins");
        Console.WriteLine("Play again? (Y/N)");
    }
    else if (userChoice == Choices.Rock && aIChoice == Choices.Paper)
    {
        Console.WriteLine($"User chose {userChoice}");
        Console.WriteLine($"Opponent chose {aIChoice}");
        Console.WriteLine("Opponent wins");
        Console.WriteLine("Play again? (Y/N)");

    }
    else if (userChoice == Choices.Paper && aIChoice == Choices.Rock)
    {
        Console.WriteLine($"User chose {userChoice}");
        Console.WriteLine($"Opponent chose {aIChoice}");
        Console.WriteLine("User wins");
        Console.WriteLine("Play again? (Y/N)");

    }
    else if (userChoice == Choices.Paper && aIChoice == Choices.Scissors)
    {
        Console.WriteLine($"User chose {userChoice}");
        Console.WriteLine($"Opponent chose {aIChoice}");
        Console.WriteLine("Opponent wins");
        Console.WriteLine("Play again? (Y/N)");

    }
    else if (userChoice == Choices.Scissors && aIChoice == Choices.Paper)
    {
        Console.WriteLine($"User chose {userChoice}");
        Console.WriteLine($"Opponent chose {aIChoice}");
        Console.WriteLine("User wins");
        Console.WriteLine("Play again? (Y/N)");

    }
    else if (userChoice == Choices.Scissors && aIChoice == Choices.Rock)
    {
        Console.WriteLine($"User chose {userChoice}");
        Console.WriteLine($"Opponent chose {aIChoice}");
        Console.WriteLine("Opponent wins");
        Console.WriteLine("Play again? (Y/N)");

    }

    string playAgain;
    while (true)
    {
        playAgain = Console.ReadLine().ToLower();
        if (playAgain != "y" && playAgain != "n")
        {
            Console.WriteLine("Invalid input try again");
            Console.WriteLine("Play again? (Y/N)");
            continue;
        }
        break;
    }
    if (playAgain == "y") { Console.Clear(); continue; }
    else break;
}


