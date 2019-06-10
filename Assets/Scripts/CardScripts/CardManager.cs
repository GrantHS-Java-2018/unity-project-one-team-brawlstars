using System.Collections;
using System.Collections.Generic;
using GameInformation;
using UnityEngine;

namespace CardScripts
{
    public static class CardManager
    {
        private static Card[] _chanceDeck = new Card[9];
        private static Card[] _communityChestDeck = new Card[13];
        private static int _currentChanceCard;
        private static int _currentCommunityChestCard;
        
        public static void SetUpCardManager()
        {
            _chanceDeck[0] = new MovementCard();
            _chanceDeck[1] = new MovementCard();
            _chanceDeck[2] = new MovementCard();
            _chanceDeck[3] = new MovementCard();
            _chanceDeck[4] = new MovementCard();
            _chanceDeck[5] = new MoneyCard();
            _chanceDeck[6] = new MoneyCard();
            _chanceDeck[7] = new MoneyCard();
            _chanceDeck[8] = new GetOutOfJailCard();
            
            //Sets up deck of chance cards
            
            _communityChestDeck[0] = new MoneyCard();
            _communityChestDeck[1] = new MoneyCard();
            _communityChestDeck[2] = new MoneyCard();
            _communityChestDeck[3] = new MoneyCard();
            _communityChestDeck[4] = new MoneyCard();
            _communityChestDeck[5] = new MoneyCard();
            _communityChestDeck[6] = new MoneyCard();
            _communityChestDeck[7] = new MoneyCard();
            _communityChestDeck[8] = new MoneyCard();
            _communityChestDeck[9] = new MoneyCard();
            _communityChestDeck[10] = new MoneyCard();
            _communityChestDeck[11] = new MovementCard();
            _communityChestDeck[12] = new GetOutOfJailCard();
            
            //Sets up deck of Community Chest cards

            var cardInformation = CardInformation.GetCardInformation(0);
            
            for (int n = 0; n < 8; n++)
            {
                cardInformation = CardInformation.GetCardInformation(n);
                _chanceDeck[n].SetUpCard(cardInformation.Item1, cardInformation.Item2);
            }
            
            for (int n = 8; n < 20; n++)
            {
                cardInformation = CardInformation.GetCardInformation(n);
                _communityChestDeck[n-8].SetUpCard(cardInformation.Item1, cardInformation.Item2);
            }
            
            ShuffleChance();
            ShuffleCommunityChest();
            //Shuffles decks before game starts
        }

        private static void ShuffleCommunityChest()
        {
            for (int n = 0; n < 500; n++)
            {
                int a = Random.Range(0,13);
                int b = Random.Range(0,13);
                Card tempCard = _communityChestDeck[a];
                _communityChestDeck[a] = _communityChestDeck[b];
                _communityChestDeck[b] = tempCard;
            }
        }
        private static void ShuffleChance()
        {
            for (int n = 0; n < 500; n++)
            {
                int a = Random.Range(0,9);
                int b = Random.Range(0,9);
                Card tempCard = _chanceDeck[a];
                _chanceDeck[a] = _chanceDeck[b];
                _chanceDeck[b] = tempCard;
            }
        }

        public static Card DealChance()
        {
            if (_currentChanceCard > 9)
            {
                ShuffleChance();
                _currentChanceCard = 0;
            }
            _currentChanceCard++;
            return _chanceDeck[_currentChanceCard-1];
        }
        
        public static Card DealCommunityChest()
        {
            if (_currentCommunityChestCard > 13)
            {
                ShuffleCommunityChest();
                _currentCommunityChestCard = 0;
            }
            _currentCommunityChestCard++;
            return _communityChestDeck[_currentCommunityChestCard-1];
        }


    }


}
