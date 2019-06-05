using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

namespace GameInformation
{
    public static class TileInformation
    {
        public static (int, String, Vector3, Sprite, int[]) GetTileInformation(int tileIndex)
        {
            int[] propertyValueArray = new int[9];
            for (int n = 0; n < 9; n++)
            {
                propertyValueArray[n] = PropertyValuesSource[tileIndex, n];
            }
            return (tileIndex, NameSource[tileIndex], Waypoints[tileIndex], _tileSprites[tileIndex], propertyValueArray);
        }

        private static Sprite[] _tileSprites;
        
        private static readonly String[] NameSource = 
        {
            "Go", 
            "Mediterranean_Avenue",
            "Community_Chest",
            "Baltic_Avenue",
            "Income_Tax",
            "Reading_Railroad",
            "Oriental_Avenue",
            "Chance",
            "Vermont_Avenue",
            "Connecticut_Avenue",
            "Jail",
            "St._Charles_Place",
            "Electric_Company",
            "States_Avenue",
            "Virginia_Avenue",
            "Pennsylvania_Railroad",
            "St._James_Place",
            "Community_Chest",
            "Tennessee_Avenue",
            "New_York_Avenue",
            "Free_Parking",
            "Kentucky_Avenue",
            "Chance",
            "Indiana_Avenue",
            "Illinois_Avenue",
            "B._&_O._Railroad",
            "Atlantic_Avenue",
            "Ventnor_Avenue",
            "Water_Works",
            "Marvin_Gardens",
            "Go_To_Jail",
            "Pacific_Avenue",
            "North_Carolina_Avenue",
            "Community_Chest",
            "Pennsylvania_Avenue",
            "Short_Line_Railroad",
            "Chance",
            "Park_Place",
            "Luxury_Tax",
            "Boardwalk"
        };
        
        //Holds the point in space where player tokens will be oriented around as related to each tile
        //FOR FUTURE REFERENCE ON TILE SIZES
        //A rectangle is 123 pixels wide, and 198 pixels tall
        //A square is 198 pixels by 198 pixels
        //To orient them correctly, multiply the pixels by (5/6) to account for monopoly board sprite scale
        //Moving between rectangles deltaX = 102.5, moving into or out of square deltaX = 133.75
        private static readonly Vector3[] Waypoints =
        {
            new Vector3(543.75f, -463.75f, -0.1f), 
            new Vector3(410f, -463.75f, -0.1f),
            new Vector3(307.5f, -463.75f, -0.1f),
            new Vector3(205f, -463.75f, -0.1f),
            new Vector3(102.5f, -463.75f, -0.1f),
            new Vector3(0f, -463.75f, -0.1f),
            new Vector3(-102.5f, -463.75f, -0.1f),
            new Vector3(-205f, -463.75f, -0.1f),
            new Vector3(-307.5f, -463.75f, -0.1f),
            new Vector3(-410f, -463.75f, -0.1f),
            new Vector3(-543.75f, -463.75f, -0.1f),
            new Vector3(-543.75f, -330f, -0.1f),
            new Vector3(-543.75f, -227.5f, -0.1f),
            new Vector3(-543.75f, -125f, -0.1f),
            new Vector3(-543.75f, -22.5f, -0.1f),
            new Vector3(-543.75f, 80f, -0.1f),
            new Vector3(-543.75f, 182.5f, -0.1f),
            new Vector3(-543.75f, 285f, -0.1f),
            new Vector3(-543.75f, 387.5f, -0.1f),
            new Vector3(-543.75f, 490f, -0.1f),
            new Vector3(-543.75f, 623.75f, -0.1f),
            new Vector3(-410f, 623.75f, -0.1f),
            new Vector3(-307.5f, 623.75f, -0.1f),
            new Vector3(-205f, 623.75f, -0.1f),
            new Vector3(-102.5f, 623.75f, -0.1f),
            new Vector3(0f, 623.75f, -0.1f),
            new Vector3( 102.5f, 623.75f, -0.1f),
            new Vector3(205f, 623.75f, -0.1f),
            new Vector3(307.5f, 623.75f, -0.1f),
            new Vector3(410f, 623.75f, -0.1f),
            new Vector3(543.75f, 623.75f, -0.1f),
            new Vector3(543.75f, 490f, -0.1f),
            new Vector3(543.75f, 387.5f, -0.1f),
            new Vector3(543.75f, 285f, -0.1f),
            new Vector3(543.75f, 182.5f, -0.1f),
            new Vector3(543.75f, 80f, -0.1f),
            new Vector3(543.75f, -22.5f, -0.1f),
            new Vector3(543.75f, -125f, -0.1f),
            new Vector3(543.75f, -227.5f, -0.1f),
            new Vector3(543.75f, -330f, -0.1f)
        };

        //Formatted with second dimension being Price, Mortgage, House Price, Rent, Rent(1h), Rent(2h), Rent(3h), Rent(4h), Rent(5h)
        //For non-real estate property tiles only first few of these variables are used, others are not used, and stay 0
        //CardDeckTile types are chosen by 1st value, 0 is chance, 1 is community chest
        //For any other tiles, these values are not used, as their functions can be described completely in their own class
        private static readonly int[,] PropertyValuesSource =
            {
                {0, 0, 0, 0, 0, 0, 0, 0, 0}, //Non-property
                {60, 30, 50, 2, 10, 30, 90, 160, 250},
                {1, 0, 0, 0, 0, 0, 0, 0, 0}, //Community Chest
                {60, 30, 50, 4, 20, 60, 180, 320, 450},
                {200, 0, 0, 0, 0, 0, 0, 0, 0}, //Non-property
                {200, 100, 0, 0, 0, 0, 0, 0, 0}, //Railroad
                {100, 50, 50, 6, 30, 90, 270, 400, 550},
                {0, 0, 0, 0, 0, 0, 0, 0, 0}, //Chance
                {100, 50, 50, 6, 30, 90, 270, 400, 550},
                {120, 60, 50, 8, 40, 100, 300, 450, 600},
                {0, 0, 0, 0, 0, 0, 0, 0, 0}, //Non-property
                {140, 70, 100, 10, 50, 150, 450, 625, 750},
                {150, 75, 0, 0, 0, 0, 0, 0, 0}, //Utility
                {140, 70, 100, 10, 50, 150, 450, 625, 750},
                {160, 80, 100, 12, 60, 180, 500, 700, 900},
                {200, 100, 0, 0, 0, 0, 0, 0, 0}, //Railroad
                {180, 90, 100, 14, 70, 200, 550, 750, 950},
                {1, 0, 0, 0, 0, 0, 0, 0, 0}, //Community Chest
                {180, 90, 100, 14, 70, 200, 550, 750, 950},
                {200, 100, 100, 16, 80, 220, 600, 800, 1000},
                {0, 0, 0, 0, 0, 0, 0, 0, 0}, //Non-property
                {220, 110, 150, 18, 90, 250, 700, 875, 1050},
                {0, 0, 0, 0, 0, 0, 0, 0, 0}, //Chance
                {220, 110, 150, 18, 90, 250, 700, 875, 1050},
                {240, 120, 150, 20, 100, 300, 750, 925, 1100},
                {200, 100, 0, 0, 0, 0, 0, 0, 0}, //Railroad
                {260, 130, 150, 22, 110, 330, 800, 975, 1150},
                {260, 130, 150, 22, 110, 330, 800, 975, 1150},
                {150, 75, 0, 0, 0, 0, 0, 0, 0}, //Utility
                {280, 140, 150, 24, 120, 360, 850, 1025, 1200},
                {0, 0, 0, 0, 0, 0, 0, 0, 0}, //Non-property
                {300, 150, 200, 26, 130, 390, 900, 1100, 1275},
                {300, 150, 200, 26, 130, 390, 900, 1100, 1275},
                {1, 0, 0, 0, 0, 0, 0, 0, 0}, //Community Chest
                {320, 160, 200, 28, 150, 450, 1000, 1200, 1400},
                {200, 100, 0, 0, 0, 0, 0, 0, 0}, //Railroad
                {0, 0, 0, 0, 0, 0, 0, 0, 0}, //Chance
                {350, 175, 200, 35, 175, 500, 1100, 1300, 1500},
                {100, 0, 0, 0, 0, 0, 0, 0, 0}, //Non-property
                {400, 200, 200, 50, 200, 600, 1400, 1700, 2000}
            };

        public static void SetUpTileInformation()
        {
            _tileSprites = new Sprite[40];
            for (int n = 0; n < 40; n ++)
            {
                if (PropertyValuesSource[n, 8] != 0)
                {
                    _tileSprites[n] = Resources.Load<Sprite>("Sprites/Deeds/" + NameSource[n]);
                }
                else
                {
                    _tileSprites[n] = null;
                }
            }
        }
    }
}