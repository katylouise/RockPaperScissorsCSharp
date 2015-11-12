using System;

namespace RockPaperScissors
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			bool play = true;
			while (play) 
			{
				RockPaperScissors rps = new RockPaperScissors ();

				Console.WriteLine ("Welcome to RockPaperScissors!");
				Console.WriteLine ("Make your choice: ");
				string user_choice = Console.ReadLine ();
				
				string computer_choice = rps.ComputerChoice ();
				
				Console.WriteLine ("The computer chose {0}.", computer_choice);
				Console.WriteLine (rps.Result(user_choice, computer_choice));

				Console.WriteLine ("Play Again? Y/N");
				string play_again = Console.ReadLine ();
				if (play_again == "N") 
				{
					Console.WriteLine("Thanks for playing!");
					play = false;
				}
			}

		}
	}
}
