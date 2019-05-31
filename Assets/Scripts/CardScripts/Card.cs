using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.CardScripts
{
    public abstract class Card : MonoBehaviour
    {

        public int cardNum;
        public abstract void SetUpCard( int[] incomingTileValues);
        public abstract void DoCardAction();

    }
        

















    }
}




