using System.Collections;
using System.Collections.Generic;
using TileScripts.SpecialTiles;
using UnityEngine;

namespace CardScripts

{
    public class MoneyCard : Card
    {
        private int _cardMoneyChange;
        public override void SetUpCard(int incomingCardValue, Sprite incomingCardSprite)
        {
            _cardMoneyChange = incomingCardValue;
            CardSprite = incomingCardSprite;
        }
        public override void DoCardAction()
        {
            GameLoop.GetCurrentPlayer().Pay(_cardMoneyChange);
            if (_cardMoneyChange < 0)
            {
                FreeParkingTile.AddToParkingPayout(-_cardMoneyChange);
            }
            //Runs method to change players money
        }
    }
}