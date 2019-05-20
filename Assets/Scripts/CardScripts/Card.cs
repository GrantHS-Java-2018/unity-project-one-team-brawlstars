using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.CardScripts
{
    public abstract class Card : MonoBehaviour
    {

        public int cat { get; set; }
        public abstract int activate(int[] amount);
        public abstract int activate();
        public abstract int activate(int cardMoney);
    }

}


