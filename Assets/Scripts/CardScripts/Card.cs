using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CardScripts
{
    public abstract class Card
    {
        protected Sprite CardSprite;
        
        public abstract void SetUpCard(int incomingCardValue, Sprite incomingCardSprite);
        //Sets up cards with their values
        public abstract void DoCardAction();
        //Does card action when called upon but overriden in subclasses
        public Sprite GetCardSprite()
        {
            return CardSprite;
        //Will return card sprite in order to display in the game
        }
    }
}




