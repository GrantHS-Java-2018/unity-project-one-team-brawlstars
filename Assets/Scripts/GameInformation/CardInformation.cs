using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameInformation
{

    public static class CardInformation
    {
        public static (int, Sprite) GetCardInformation(int cardIndex)
        {
            return (CardValuesSource[cardIndex], _cardSprites[cardIndex]); 
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
            0,

            //Community Chest
            25,
            10,
            -50,
            20,
            100,
            200,
            -100,
            -150,
            100,
            45,
            100,
            0,
            0
        };

        public static void SetUpCardInformation()
        {
            _cardSprites = new Sprite[22];
            for (int n = 0; n < 9; n++)
            {
                _cardSprites[n] = Resources.Load<Sprite>("Sprites/Cards/Chance/Implemented/Chance" + n);
            }

            for (int n = 9; n < 22; n++)
            {
                _cardSprites[n] =
                    Resources.Load<Sprite>("Sprites/Cards/CommunityChest/Implemented/CommunityChest" + (n - 9));
            }
        }
    }
}