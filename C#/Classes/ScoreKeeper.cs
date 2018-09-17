using System.Collections.Generic;
using System.Linq;

namespace Singleton.Classes
{
	public class ScoreKeeper
	{
		#region Singleton Setup
		private static ScoreKeeper _scoreKeeper;

		// This is important for this pattern
		// You do not want users to create instances of this class
		// Instead, they should access the class via the GetInstance method
		private ScoreKeeper()
		{
			_scores = new Dictionary<string, int>();
		}

		public static ScoreKeeper GetInstance()
		{
			if (_scoreKeeper == null)
				_scoreKeeper = new ScoreKeeper();

			return _scoreKeeper;
		}
		#endregion

		private IDictionary<string, int> _scores;

		public void IncrementScore(string playerName)
		{
			if (!_scores.Keys.Any(x => x == playerName))
				_scores.Add(playerName, 0);

			_scores[playerName] += 1;
		}

		public IDictionary<string, int> GetScores()
		{
			return _scores;
		}
	}
}
