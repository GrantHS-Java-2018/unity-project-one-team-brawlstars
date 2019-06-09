using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameInformation
{

    public static class CardInformation
    {
        public static int GetCardInformation(int cardIndex)
        {
            return CardValuesSource[cardIndex];
        }

        private static Sprite[] _cardSprites;

        private static readonly int[] CardValuesSource =
        {
            //Chance
            24,
            39,
            0,
            5,
            11,
            50,
            150,
            -15,

            //Community Chest
            25,
            10,
            -50,
            20,
            100,
            200,
            100,
            -150,
            -100,
            45,
            100,
            0
        };

        private static void SetUpCardInformation()
        {
            
        }
    }
}