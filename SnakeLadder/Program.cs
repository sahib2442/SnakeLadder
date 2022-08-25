using System;
namespace SnakeAndLadder
{
    internal class Game
    {
        public int DiceRoll()
        {
            Random random = new Random();
            int diceCount = random.Next(1,7);
            return diceCount;
        }
    }
}
