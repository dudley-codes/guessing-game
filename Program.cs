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

    success = int.TryParse(Console.ReadLine(), out answer);
    if(success)
    {
      if(SecretNumber == answer)
      {
      Console.WriteLine("You guessed correct!");
      }
      else
      {
        Console.WriteLine("Wrong. Guess again!");
      }
    }
    else
    {
      Console.Write("Please enter a number: ");
    }

    }
}