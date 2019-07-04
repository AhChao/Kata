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
            if (_firstPlayerScore == _secondPlayerScore && _firstPlayerScore >= 3) return "Deuce";
            if (_firstPlayerScore == _secondPlayerScore) return ScoreString[_secondPlayerScore] + " All";
            if (_firstPlayerScore >= 4 && _firstPlayerScore > _secondPlayerScore )
            {
                if (_firstPlayerScore - _secondPlayerScore == 1)
                    return "Player1 Adv";
                else
                    return "Player1 Won";
            }

            if (_secondPlayerScore >= 4)
            {
                if (_secondPlayerScore - _firstPlayerScore >= 2)
                    return "Player2 Won";
                else
                    return "Player2 Adv";
            }

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
