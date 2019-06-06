using System.Collections;
using System.Collections.Generic;
using TileScripts;
using UnityEngine;

namespace CardScripts
{
    public class MovementCards : Card

    {
        private int cardWaypoint;

        public override void SetUpCard(int incomingCardValue)
        {
            cardWaypoint = incomingCardValue;
        }

        public override void DoCardAction()
        {

        }
    }
}