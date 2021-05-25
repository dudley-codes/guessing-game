using System;

Main();

void Main()
{
  GuessNum();
}

void GuessNum()
{
  int guess = SelectDifficulty();
  // Prompt user for their guess
  Console.Write("Can you guess the number between 0 and 100?: ");
  int answer;
  bool success = false;
  var rand = new Random();
  // Generate random int between 0 and 100
  int SecretNumber = rand.Next(101);
  // Until user guesses number or guesses run out, continue to promput user for guess
  for (int i = guess; i > 0; i--)
  {
    // Checks to see if user entry can be parsed. If yes, returns true.
    // If false, prompts user to enter a number.
    success = int.TryParse(Console.ReadLine(), out answer);
    if (success)
    {
      if (SecretNumber == answer)
      {
        Console.WriteLine("You guessed correct!");
        break;
      }
      else
      {
        if (i > 1)
        {
          if (answer > SecretNumber)
          {
            Console.WriteLine("Too high!");
          }
          else
          {
            Console.WriteLine("Too low!");
          }
          Console.WriteLine($@"You have {i - 1} guesses remaining.");
          Console.Write("Guess again: ");
        }
        else
        {
          Console.WriteLine("Sorry, you ran out of guesses.");
        }
      }
    }
    else
    {
      Console.Write("Please enter a number: ");
    }
  }
}

int SelectDifficulty()
{
  // Select difficulty of game.
  Console.Write("Select Easy, Medium, Difficult, or Cheater (E/M/D/C): ");
  string difficulty = Console.ReadLine().ToLower();

  while (difficulty != "e" && difficulty != "m" && difficulty != "d" && difficulty != "c")
  {
    // If incorrect option is selected, continue to prompt user for correct input
    Console.Write("Select Easy, Medium, Difficult, or Cheater (E/M/D/C): ");
    difficulty = Console.ReadLine().ToLower();
  }
  int guess = 0;
  switch (difficulty)
  {
    case "e":
      guess = 8;
      break;
    case "m":
      guess = 6;
      break;
    case "d":
      guess = 4;
      break;
    case "c":
      guess = int.MaxValue;
      break;
  }

  return guess;
}