using System;

namespace TennisKata
{
    class CounterController
    {
        public void FirstPlayerScore(CounterModel counterModel)
        {
            if (!isMatchEnd(counterModel)) counterModel.PlayerOneScore++;
        }
        public void SecondPlayerScore(CounterModel counterModel)
        {
            if (!isMatchEnd(counterModel)) counterModel.PlayerTwoScore++;
        }
        public void ResetCounter(CounterModel counterModel)
        {
            counterModel.PlayerOneScore = 0;
            counterModel.PlayerTwoScore = 0;
        }
        public bool isMatchEnd(CounterModel counterModel)
        {
            if (counterModel.PlayerOneScore >= 4 && counterModel.PlayerOneScore - counterModel.PlayerTwoScore >= 2) return true;
            if (counterModel.PlayerTwoScore >= 4 && counterModel.PlayerTwoScore - counterModel.PlayerOneScore >= 2) return true;
            return false;
        }

        public string Score(CounterModel counterModel)
        {
            String[] dict = new string[] { "Love", "Fifteen", "Thirty", "Forty" };
            if (counterModel.PlayerOneScore == counterModel.PlayerTwoScore)
            {
                if (counterModel.PlayerOneScore >= 3) return "Deuce";
                return dict[counterModel.PlayerOneScore] + " All";
            }
            else
            {
                if (counterModel.PlayerOneScore < 4 && counterModel.PlayerTwoScore < 4)
                {
                    return dict[counterModel.PlayerOneScore] + " " + dict[counterModel.PlayerTwoScore];
                }
                else
                {
                    if (Math.Abs(counterModel.PlayerOneScore - counterModel.PlayerTwoScore) < 2)
                    {
                        if (counterModel.PlayerOneScore > counterModel.PlayerTwoScore)
                        {
                            return "PlayerA Adv";
                        }
                        else
                        {
                            return "Player2 Adv";
                        }
                    }
                    else
                    {
                        if (counterModel.PlayerOneScore > counterModel.PlayerTwoScore)
                        {
                            return "PlayerA Won";
                        }
                        else
                        {
                            return "Player2 Won";
                        }

                    }
                }
            }
        }

    }
}
