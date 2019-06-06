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
            -100,
            -150,
            45,
            100,
            0
                        
        };
        
        

}
