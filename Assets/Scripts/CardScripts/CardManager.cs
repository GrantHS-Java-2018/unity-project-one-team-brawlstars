using System.Collections;
using System.Collections.Generic;
using GameInformation;
using UnityEngine;

namespace CardScripts
{
    public class CardManager : MonoBehaviour
    {
        public Card[] chanceDeck = new Card[8];
        public Card[] communityChestDeck = new Card[12];
        int _currentChanceCard;
        int _currentCommunityChestCard;

        public void Start()
        {
            chanceDeck[0] = gameObject.AddComponent<MovementCards>();
            chanceDeck[1] = gameObject.AddComponent<MovementCards>();
            chanceDeck[2] = gameObject.AddComponent<MovementCards>();
            chanceDeck[3] = gameObject.AddComponent<MovementCards>();
            chanceDeck[4] = gameObject.AddComponent<MovementCards>();
            chanceDeck[5] = gameObject.AddComponent<MoneyCards>();
            chanceDeck[6] = gameObject.AddComponent<MoneyCards>();
            chanceDeck[7] = gameObject.AddComponent<MoneyCards>();
            chanceDeck[8] = gameObject.AddComponent<GetOutOfJailCard>();
            
            //Sets up deck of chance cards
            
            communityChestDeck[0] = gameObject.AddComponent<MoneyCards>();
            communityChestDeck[1] = gameObject.AddComponent<MoneyCards>();
            communityChestDeck[2] = gameObject.AddComponent<MoneyCards>();
            communityChestDeck[3] = gameObject.AddComponent<MoneyCards>();
            communityChestDeck[4] = gameObject.AddComponent<MoneyCards>();
            communityChestDeck[5] = gameObject.AddComponent<MoneyCards>();
            communityChestDeck[6] = gameObject.AddComponent<MoneyCards>();
            communityChestDeck[7] = gameObject.AddComponent<MoneyCards>();
            communityChestDeck[8] = gameObject.AddComponent<MoneyCards>();
            communityChestDeck[9] = gameObject.AddComponent<MoneyCards>();
            communityChestDeck[10] = gameObject.AddComponent<MoneyCards>();
            communityChestDeck[11] = gameObject.AddComponent<MovementCards>();
            communityChestDeck[12] = gameObject.AddComponent<GetOutOfJailCard>();
            
            //Sets up deck of Community Chest cards
            
            for (int n = 0; n < 8; n++)
            {
            chanceDeck[n].SetUpCard(CardInformation.GetCardInformation(n));
            }
            
            for (int n = 8; n < 20; n++)
            {
            communityChestDeck[n-8].SetUpCard(CardInformation.GetCardInformation(n));
            }
            
            ShuffleChance();
            ShuffleCommunityChest();
            //Shuffles decks before game starts
        }

        public void ShuffleCommunityChest()
        {
            for (int n = 0; n < 500; n++)
            {
                int a = Random.Range(0,13);
                int b = Random.Range(0,13);
                Card tempCard = communityChestDeck[a];
                communityChestDeck[a] = communityChestDeck[b];
                communityChestDeck[b] = tempCard;
            }
        }
        public void ShuffleChance()
        {
            for (int n = 0; n < 500; n++)
            {
                int a = Random.Range(0,9);
                int b = Random.Range(0,9);
                Card tempCard = chanceDeck[a];
                chanceDeck[a] = chanceDeck[b];
                chanceDeck[b] = tempCard;
            }
        }

        public Card DealChance()
        {
            if (_currentChanceCard > 9)
            {
                ShuffleChance();
                _currentChanceCard = 0;
            }
            _currentChanceCard++;
            return chanceDeck[_currentChanceCard-1];
            
        }
        
        public Card DealCommuntiyChest()
        {
            if (_currentCommunityChestCard > 13)
            {
                ShuffleCommunityChest();
                _currentCommunityChestCard = 0;
            }
            _currentCommunityChestCard++;
            return communityChestDeck[_currentCommunityChestCard-1];
            
        }


    }


}
