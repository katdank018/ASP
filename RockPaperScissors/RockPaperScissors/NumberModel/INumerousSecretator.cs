using System;
namespace NumberGame
{
    public interface INumerousSecretator
    {
        int TipCounter { get; }
        bool Guessed { get; }
        GameState LastGuessState { get; }
        bool Guess(int number);
    }
}
