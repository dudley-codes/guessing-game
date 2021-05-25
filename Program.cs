﻿using System;

GuessNum();

void GuessNum()
{
    Console.Write("Can you guess the secret number?: ");
    int answer;
    bool success = false;

    while (success == false)
    {

    success = int.TryParse(Console.ReadLine(), out answer);
    if(success)
    {
      Console.WriteLine("You guessed {0}", answer);
    }
    else
    {
      Console.Write("Please enter a number: ");
    }

    }
}