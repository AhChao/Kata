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
        private int _secondPlayerScore;

        public string ScoreMsg()
        {
            Dictionary<int,string> ScoreString = new Dictionary<int,string>()
            {
                {0,"Love"},
                {1,"Fifteen"},
                {2,"Thirty"},
                {3,"Forty"},
            };
            if (_firstPlayerScore == 0 && _secondPlayerScore == 0) return "Love All";
            if (_firstPlayerScore == 4) return "Player1 Won";
             return ScoreString[_firstPlayerScore] + " " + ScoreString[_secondPlayerScore];    
        }

        public void FirstPlayerScore(int score)
        {
            _firstPlayerScore += score;
        }
        public void SecondPlayerScore(int score)
        {
            _secondPlayerScore += score;
        }
    }
}
