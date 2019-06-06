using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CardScripts
{
    public class CardManager : MonoBehaviour
    {
        public Card[] chanceDeck = new Card[8];
        public Card[] communityChestDeck = new Card[12];

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
         
         
         for (int n = 0; n < 8; n++)
         {
             chanceDeck[n].SetUpCard(CardInformation.GetCardInformation(n));
         }
         
         for (int n = 8; n < 20; n++)
         {
             communityChestDeck[n-8].SetUpCard(CardInformation.GetCardInformation(n));
         }
        }
        

    }


}
