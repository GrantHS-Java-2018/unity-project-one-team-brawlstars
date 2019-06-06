using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CardScripts
{
    public abstract class Card : MonoBehaviour
    {

        //public int cardNum;
        public abstract void SetUpCard(int incomingCardValue);
        public abstract void DoCardAction();

    }
}




