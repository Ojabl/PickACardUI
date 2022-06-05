using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickACardUI
{
    internal class CardPicker
    {
        static Random random = new Random(); //new random generator


        public static string[] PickSomeCards(int numberOfCards) // returns required amount of random cards
        {
            string[] pickedCards = new string[numberOfCards];
            for(int i=0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }
            return pickedCards;
        }

        private static string RandomValue() // random number for new card
        {
            int value = random.Next(1,14); // generate random number from 1 to 13
            if (value == 1) return "Ace"; // 1 -> ace
            if (value == 11) return "Jack"; // 11 -> jack
            if (value == 12) return "Queen"; // 12 -> queen
            if (value == 13) return "King"; // 13 -> king
            return value.ToString(); //if not a court card, return value from 2 to 10
        }

        private static string RandomSuit() // random suit for new card //### CAN MAKE IT USING SWITCH ? ###
        {
            int value = random.Next(1,5); // generate random number from 1 to 4
            if (value == 1) return "Spades"; // if 1 -> spades
            if (value == 2) return "Hearts"; // if 2 -> hearts
            if (value == 3) return "Clubs"; // if 3 -> clubs
            else return "Diamonds"; // if 4 -> diamonds
        }
    }
}
