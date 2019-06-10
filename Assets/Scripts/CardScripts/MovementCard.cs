using System.Collections;
using System.Collections.Generic;
using TileScripts;
using UnityEngine;

namespace CardScripts
{
    public class MovementCard : Card

    {
        private int cardWaypoint;
        private PlayerMovement _playerMovement;

        public override void SetUpCard(int incomingCardValue, Sprite incomingCardSprite)
        {
            cardWaypoint = incomingCardValue;
            CardSprite = incomingCardSprite;
            _playerMovement = GameObject.Find("PlayerMovement").GetComponent<PlayerMovement>();
        }

        public override void DoCardAction()
        {
            _playerMovement.SendPlayer(cardWaypoint);
        }
    }
}