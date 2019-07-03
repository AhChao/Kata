using System;

namespace TennisKata
{
    class Program
    {
        static void Main(string[] args)
        {
            CounterModel counter = new CounterModel();
            CounterController counterController = new CounterController();
            Counter_0_0_Sould_be_Love_All(counter, counterController);
            Counter_3_3_Sould_be_Deuce(counter, counterController);
            Console.Write("\nTest Done.\n");
            Console.ReadLine();
        }
        static void Counter_0_0_Sould_be_Love_All(CounterModel counter, CounterController counterController)
        {
            counterController.ResetCounter(counter);
            string result = counterController.Score(counter);
            if (result != "Love All") Console.Write($"0:0 |Test Error : {result} should be Love All");
        }

        static void Counter_3_3_Sould_be_Deuce(CounterModel counter, CounterController counterController)
        {
            counterController.ResetCounter(counter);
            counterController.FirstPlayerScore(counter);
            counterController.SecondPlayerScore(counter);
            counterController.FirstPlayerScore(counter);
            counterController.SecondPlayerScore(counter);
            counterController.FirstPlayerScore(counter);
            counterController.SecondPlayerScore(counter);
            string result = counterController.Score(counter);
            if (result != "Deuce") Console.Write($"3:3 | Test Error : {result} should be Deuce");
        }

    }
}
