/*
	The Singleton Design Pattern prevents a user from instantiating more than one object.
	There are many uses for this pattern, but at its core, the job of a Singleton is to share the object's instance across code.
	Hence "Single" when thinking about what it does.
 */

using Singleton.Classes;
using System;

namespace Singleton
{
	class Program
	{
		static void Main(string[] args)
		{
			AddToPlayer("Player 1");
			PrintScores();
			AddToPlayer("Player 2");
			PrintScores();
			AddToPlayer("Player 2");
			PrintScores();
			AddToPlayer("Player 3");
			PrintScores();
			AddToPlayer("Player 2");
			PrintScores();

			Console.ReadLine();
		}

		private static void AddToPlayer(string playerName)
		{
			var singleton = ScoreKeeper.GetInstance();

			Console.WriteLine($"Score given to {playerName}!");

			singleton.IncrementScore(playerName);
		}

		private static void PrintScores()
		{
			var singleton = ScoreKeeper.GetInstance();

			var scores = singleton.GetScores();

			foreach(var s in scores)
			{
				Console.WriteLine($"{s.Key} = {s.Value}");
			}

			Console.WriteLine("----------");
		}
	}
}
