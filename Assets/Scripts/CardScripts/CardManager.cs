using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CardScripts
{
    public class CardManager : MonoBehaviour
    {
        public Card[] deck = new Card[7];

        public void Start()
        {
         deck[0] = gameObject.AddComponent<MovementCards>();
         
         
         
         for (int n = 0; n < 7; n++)
         {
                deck[n].SetUpCard(CardInformation.GetCardInformation(n));
         }
        }
        

    }


}
