using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisKata_TDD
{
    class TennisCounter
    {
        private int _firstPlayerScore;

        public string ScoreMsg()
        {
            Dictionary<int,string> ScoreString = new Dictionary<int,string>()
            {
                {1,"Fifteen"},
                {2,"Thirty"},
                {3,"Forty"},
            };
            if (_firstPlayerScore >= 1) return ScoreString[_firstPlayerScore] + " Love";

            return "Love All";
        }

        public void FirstPlayerScore()
        {
            _firstPlayerScore++;
        }
    }
}
