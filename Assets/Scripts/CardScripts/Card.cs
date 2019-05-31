using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.CardScripts
{
    public abstract class Card : MonoBehaviour
    {
        private int cardCat;
        private int cardValue;
        private int[] Cat = {1, 2, 3, 4, 5};
        private int[] Value = {44,45,43,345,4,8};

        public Card(int cat, int value)
        {

            cardCat = cat;

            cardValue = value;
        }
        

















    }
}




