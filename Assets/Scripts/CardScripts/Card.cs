using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CardScripts
{
    public abstract class Card : MonoBehaviour
    {

        //public int cardNum;
        public abstract void SetUpCard(int incomingCardValue);
        //Sets up cards with their values
        public abstract void DoCardAction();
        //Does card action when called upon but overriden in subclasses

    }
}




