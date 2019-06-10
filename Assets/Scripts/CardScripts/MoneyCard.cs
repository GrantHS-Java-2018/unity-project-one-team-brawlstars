using System.Collections;
using System.Collections.Generic;
using TileScripts.SpecialTiles;
using UnityEngine;

namespace CardScripts

{
    public class MoneyCard : Card
    {
        private int cardMoneyChange;
        public override void SetUpCard(int incomingCardValue, Sprite incomingCardSprite)
        {
            cardMoneyChange = incomingCardValue;
            CardSprite = incomingCardSprite;
        }
        public override void DoCardAction()
        {
            GameLoop.GetCurrentPlayer().Pay(cardMoneyChange);
            if (cardMoneyChange < 0)
            {
                FreeParkingTile.AddToParkingPayout(-cardMoneyChange);
            }
            //Runs method to change players money
        }
    }
}