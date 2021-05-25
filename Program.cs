using System;

GuessNum();

void GuessNum()
{
  int guess = 8;
  Console.Write("Select Easy, Medium, or Difficult (E/M/D): ");
  string difficulty = Console.ReadLine().ToLower();

  while (difficulty != "e" && difficulty != "m" && difficulty != "d")
  {
    Console.Write("Select a difficulty level (E/M/D)");
    difficulty = Console.ReadLine().ToLower();
  }

  if (difficulty == "e")
  {
    guess = 8;
  }
  else if (difficulty == "m")
  {
    guess = 6;
  }
  else if (difficulty == "d")
  {
    guess = 4;
  }

  Console.Write("Can you guess the secret number?: ");
  int answer;
  bool success = false;
  var rand = new Random();

  int SecretNumber = rand.Next(101);

  while (!success)
  {
    for (int i = guess; i > 0; i--)
    {

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
}