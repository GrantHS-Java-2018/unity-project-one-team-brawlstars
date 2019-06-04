using System.Collections;
using System.Collections.Generic;
using Scripts.CardScripts;
using TileScripts;
using UnityEngine;

namespace Scripts.CardScripts
{
    public class MovementCards : Card

    {
        private int cardWaypoint;

        public override void SetUpCard(int incomingCardValues)
        {
            cardWaypoint = incomingCardValues;
        }

        public override void DoCardAction()
        {

        }
    }
}