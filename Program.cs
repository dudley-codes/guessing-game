using System;

GuessNum();

void GuessNum()
{
  Console.Write("Can you guess the secret number?: ");
  int answer;
  bool success = false;
  int SecretNumber = 42;

  while (success == false)
  {
    for (int i = 4; i > 0; i--)
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
            Console.Write("Wrong! Guess again: ");
          }
          else
          {
            Console.WriteLine("Sorry, you ran out of guesses");
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