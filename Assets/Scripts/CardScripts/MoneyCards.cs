using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CardScripts

{
    public class MoneyCards : Card
    {
        private int cardMoneyChange;
        public override void SetUpCard(int incomingCardValue)
        {
            cardMoneyChange = incomingCardValue;
            //Initializes value for card
        }
        public override void DoCardAction()
        {
            GameLoop.GetCurrentPlayer().Pay(cardMoneyChange);
            //Runs method to change players money
        }
    }
}