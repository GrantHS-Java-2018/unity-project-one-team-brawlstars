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
        }

        public override void DoCardAction()
        {
            GameLoop.GetCurrentPlayer().Pay(cardMoneyChange);   
        }
    }
}