namespace TennisKata
{
    class CounterModel
    {
        public int PlayerOneScore { get; set; }
        public int PlayerTwoScore { get; set; }
        public CounterModel()
        {
            PlayerOneScore = 0;
            PlayerTwoScore = 0;
        }
    }
}
