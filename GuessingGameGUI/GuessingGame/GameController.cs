using System;

namespace GuessingGame
{
    class GameController
    {
        // declarations
        private static Random randomGenerator;
        private int gameNumber, guessCounter;

        // properties
        public int GameNumber
        {
            get => gameNumber;
            private set => gameNumber = value;
        }

        public int GuessCounter
        {
            get => guessCounter;
            private set => guessCounter = value;
        }

        // constructor
        public GameController()
        {
            randomGenerator = new Random();
            GameNumber = randomGenerator.Next(1, 1001);
        }

        // resets the game
        public void ResetGame()
        {
            GuessCounter = 0;
            GameNumber = randomGenerator.Next(1, 1001);
        }

        // counts a guess
        public void CountGuess()
        {
            ++GuessCounter;
        }
    }
}
