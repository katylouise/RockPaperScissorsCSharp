using System;
using System.Collections.Generic;

namespace RockPaperScissors
{
	public class RockPaperScissors
	{
		public string ComputerChoice ()
		{
			string[] choices = new string[] {"rock", "paper", "scissors"};
			Random rnd = new Random ();
			int index = rnd.Next(0, choices.Length);
			return choices[index];
		}

		public string Result (string choice1, string choice2)
		{
			Dictionary<string, string> rules = new Dictionary<string, string> ();
			rules.Add ("rock", "scissors");
			rules.Add ("paper", "rock");
			rules.Add ("scissors", "paper");
			if (!rules.ContainsKey(choice1)) {
				return "You didn't make a sensible choice!";
			}
			else if (rules [choice1] == choice2) 
			{
				return "You win!";
			} 
			else if (rules [choice2] == choice1) 
			{
				return "You lose!";
			} 
			else
			{
				return "A draw!";
			}

		}

	}
}
