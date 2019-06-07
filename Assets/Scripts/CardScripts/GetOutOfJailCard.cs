using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CardScripts

{
    public class GetOutOfJailCard : Card
    {
        public override void SetUpCard(int incomingCardValue)
        {

        }
        public override void DoCardAction()
        {
            GameLoop.GetCurrentPlayer().ChangeGetOutOfJailCard(true);

        }


    }
}