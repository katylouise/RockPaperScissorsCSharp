using NUnit.Framework;
using System;

namespace RockPaperScissors
{
	[TestFixture ()]
	public class RPSTest
	{
		RockPaperScissors rps;

		[SetUp ()]
		public void RPSCreation ()
		{
			rps = new RockPaperScissors ();
		}

		[Test ()]
		public void Returns_Win_For_Rock_And_Scissors ()
		{
			string result = rps.Result ("rock", "scissors");
			Assert.AreEqual ("You win!", result);
		}

		[Test ()]
		public void Returns_Win_For_Scissors_And_Paper ()
		{
			string result = rps.Result ("scissors", "paper");
			Assert.AreEqual ("You win!", result);
		}

		[Test ()]
		public void Returns_Win_For_Paper_And_Rock ()
		{
			string result = rps.Result ("paper", "rock");
			Assert.AreEqual ("You win!", result);
		}

		[Test ()]
		public void Returns_Lose_For_Rock_And_Paper ()
		{
			string result = rps.Result ("rock", "paper");
			Assert.AreEqual ("You lose!", result);
		}

		[Test ()]
		public void Returns_Win_For_Scissors_And_Rock ()
		{
			string result = rps.Result ("scissors", "rock");
			Assert.AreEqual ("You lose!", result);
		}

		[Test ()]
		public void Returns_Win_For_Paper_And_Scissors ()
		{
			string result = rps.Result ("paper", "scissors");
			Assert.AreEqual ("You lose!", result);
		}

		[Test ()]
		public void Returns_Win_For_Paper_And_Paper ()
		{
			string result = rps.Result ("paper", "paper");
			Assert.AreEqual ("A draw!", result);
		}

		[Test ()]
		public void Returns_Win_For_Rock_And_Rock ()
		{
			string result = rps.Result ("rock", "rock");
			Assert.AreEqual ("A draw!", result);
		}

		[Test ()]
		public void Returns_Win_For_Scissors_And_Scissors ()
		{
			string result = rps.Result ("scissors", "scissors");
			Assert.AreEqual ("A draw!", result);
		}

		[Test ()]
		public void Returns_Message_For_Non_RPS_Choice ()
		{
			string result = rps.Result ("pillow", "rock");
			Assert.AreEqual ("You didn't make a sensible choice!", result);
		}
	}
}
