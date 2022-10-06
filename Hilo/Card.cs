using System;

/// Here we create a random number for our game. The Cards! 
namespace Unit02.Game
{

    public class randomNumer
    {
        public int _value = 0;
        public randomNumer()
        {
        }
        public int Roll()
        {
            Random random = new Random();
            _value = random.Next(1, 13);
            return _value;
        }

    }
}