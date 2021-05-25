using System;

GuessNum();


void GuessNum()
{
  Console.Write("Can you guess the secret number?: ");
  int answer;
  bool success = false;
  var rand = new Random();

  int SecretNumber = rand.Next(101);

  // Console.WriteLine($@"The secret number is: {SecretNumber}");

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
            Console.WriteLine($@"You have {i - 1} guesses remaining.");
            Console.Write("Guess again: ");
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