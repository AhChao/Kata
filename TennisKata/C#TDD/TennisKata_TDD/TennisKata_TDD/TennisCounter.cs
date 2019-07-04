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
            if (_firstPlayerScore == 1) return "Fifteen Love";
            if (_firstPlayerScore == 2) return "Thirty Love";
            if (_firstPlayerScore == 3) return "Forty Love";
            return "Love All";
        }

        public void FirstPlayerScore()
        {
            _firstPlayerScore++;
        }
    }
}
