using System;
namespace NumberGame
{
    public class RandomNumber : INumerousSecretator
    {
        static Random rand = new Random();

        private int SecretNumber { get; }

        public int TipCounter { get; private set; }

        public bool Guessed { get; private set; }

        public GameState LastGuessState { get; private set; }

        public bool Guess(int number)
        {
            TipCounter ++;
            if (SecretNumber == number)
            {
                LastGuessState = GameState.IsEqual;
                Guessed = true;
                return Guessed;
            }
            else if (SecretNumber > number)
            {
                LastGuessState = GameState.IsGreater;
                Guessed = false;
                return Guessed;
            }
            else if (SecretNumber < number)
            {
                LastGuessState = GameState.IsLess;
                Guessed = false;
                return Guessed;
            }
            Guessed = false;
            return Guessed;
        }

        public RandomNumber(int min = 1, int max = 10)
        {
            SecretNumber = rand.Next(min, max);
        }
    }
}
