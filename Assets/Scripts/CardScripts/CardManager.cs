using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.CardScripts
{
    public class CardManager : MonoBehaviour
    {
        public Card[] deck = new Card[7];

        public void Start()
        {
         deck[0] = new MovementCards();
         
         
         
         for (int n = 0; n < 7; n++)
         {
                var cardInfoPlace = CardInformation.GetCardInformation();
                deck[n].SetUpCard(cardInfoPlace);
         }
        }
        

    }


}
