using System;
using System.Collections.Generic;
/// Here we have almost all the funtions that we use in our code! 
namespace Unit02.Game
{
 
    public class Director
    {
        List<randomNumer> _dice = new List<randomNumer>();
        bool _isPlaying = true;
        int _totalScore = 300;

        public void StartGame()
        {
            while (_isPlaying)
            {
                Console.Clear();
                int firstCard = GetCard();
                DisplayCard(firstCard);
                int secondCard = GetCard();
                GetInputs(firstCard, secondCard);                
                DoOutputs();
            }
        }


        public void GetInputs(int firstCard, int secondCard)
        {
            Console.Write("Higher or lover? [h/l] ");
            string input = Console.ReadLine();
            Compare(input, firstCard, secondCard);
        }

        public void Compare(string answer, int firstCard, int secondCard)
        {
            Console.WriteLine($"Next card was: {secondCard}");

            if (answer == "h"){
                if (secondCard<firstCard){
                    
                    _totalScore -= 75 ;

                }  
                if(secondCard>firstCard){
                    _totalScore += 100 ;
                }
            }

            if (answer == "l"){
                if (secondCard<firstCard){
                    _totalScore -= 75 ;
                }  
                if(secondCard>firstCard){
                    _totalScore += 100 ;
                }
            }
        }
        


        public int GetCard()
        {
            randomNumer die = new randomNumer();
            int card = die.Roll();
            return card;
        }
        public void DisplayCard(int firstCard)
        {
            Console.WriteLine($"the card is: {firstCard}");
        }


        public void DoOutputs()
        {
            Console.WriteLine($"Your score is: {_totalScore}");
            if (!_isPlaying)
            {
                return;
            }
            Console.Write("Play again? [y/n] ");
            string again = Console.ReadLine();
            _isPlaying = (_totalScore > 0);

            if (again == "y"){
                Console.Clear();
                _isPlaying = true;
            }
            else{
                Console.Write("Thanks for playing!! ");
                _isPlaying = false;
            }
        }
    }
}

