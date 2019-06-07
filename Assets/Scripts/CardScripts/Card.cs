using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CardScripts
{
    public abstract class Card : MonoBehaviour
    {

        //public int cardNum;
        public abstract void SetUpCard(int incomingCardValue);
        //Sets up cards with there values
        public abstract void DoCardAction();
        //Does card action when called upon

    }
}




