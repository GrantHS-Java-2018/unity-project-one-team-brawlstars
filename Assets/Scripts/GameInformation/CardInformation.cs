using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CardInformation
{
        public static int GetCardInformation(int cardIndex)
        {
            return CardValuesSource[cardIndex];
        }





        private static readonly int[] CardValuesSource =
        {
            24,
            39,
            0,
            -1,
            -3,
            50,
            -50





        };

}
