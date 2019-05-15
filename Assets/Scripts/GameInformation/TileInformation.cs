using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameInformation
{
    public static class TileInformation
    {
        public static (String, Vector3, int[]) GetTileInformation(int tileIndex)
        {
            int[] propertyValueArray = new int[9];
            for (int n = 0; n < 9; n++)
            {
                propertyValueArray[n] = PropertyValuesSource[tileIndex, n];
            }
            return (NameSource[tileIndex], Waypoints[tileIndex], propertyValueArray);
        }
        
        private static readonly String[] NameSource = 
        {
            "Go", 
            "Mediterranean Avenue", 
            "Community Chest", 
            "Baltic Avenue", 
            "Income Tax", 
            "Reading Railroad",
            "Oriental Avenue", 
            "Chance", 
            "Vermont Avenue", 
            "Connecticut Avenue",
            "Jail",
            "St. Charles Place",
            "Electric Company",
            "States Avenue",
            "Virginia Avenue",
            "Pennsylvania Railroad",
            "St. James Place",
            "Community Chest",
            "Tennessee Avenue",
            "New York Avenue",
            "Free Parking",
            "Kentucky Avenue",
            "Chance",
            "Indiana Avenue",
            "Illinois Avenue",
            "B. & O. Railroad",
            "Atlantic Avenue",
            "Ventnor Avenue",
            "Water Works",
            "Marvin Gardens",
            "Go To Jail",
            "Pacific Avenue",
            "North Carolina Avenue",
            "Community Chest",
            "Pennsylvania Avenue",
            "Short Line",
            "Chance",
            "Park Place",
            "Luxury Tax",
            "Boardwalk"
        };
        
        //Holds the point in space where player tokens will be oriented around as related to each tile, enter proper coordinates in each vector parameter box
        private static readonly Vector3[] Waypoints =
        {
            new Vector3(),
            new Vector3(),
            new Vector3(),
            new Vector3(),
            new Vector3(),
            new Vector3(),
            new Vector3(),
            new Vector3(),
            new Vector3(),
            new Vector3(),
            new Vector3(),
            new Vector3(),
            new Vector3(),
            new Vector3(),
            new Vector3(),
            new Vector3(),
            new Vector3(),
            new Vector3(),
            new Vector3(),
            new Vector3(),
            new Vector3(),
            new Vector3(),
            new Vector3(),
            new Vector3(),
            new Vector3(),
            new Vector3(),
            new Vector3(),
            new Vector3(),
            new Vector3(),
            new Vector3(),
            new Vector3(),
            new Vector3(),
            new Vector3(),
            new Vector3(),
            new Vector3(),
            new Vector3(),
            new Vector3(),
            new Vector3(),
            new Vector3(),
            new Vector3()
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
                {0, 0, 0, 0, 0, 0, 0, 0, 0}, //Non-property
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
                {0, 0, 0, 0, 0, 0, 0, 0, 0}, //Non-property
                {400, 200, 200, 50, 200, 600, 1400, 1700, 2000},
            };
        
        



        /*for (int n = 0; n < 40; n++) //This for loop simply positions waypoints so they can be referenced later for movement
    {
        //If statements tell the change in x or y for the next waypoint vs the previous one
        float deltaX = 0f;
        float deltaY = 0f;
        if (n == 0)
        {
            deltaX = -0.97f;
        }
        else if (n == 1 || n == 10)
        {
            deltaX = -1.585f;
        }
        else if (n > 1 && n < 10)
        {
            deltaX = -1.23f;
        }
        else if (n == 11 || n == 20)
        {
            deltaY = 1.585f;
        }
        else if (n > 11 && n < 20)
        {
            deltaY = 1.23f;
        }
        else if (n == 21 || n == 30)
        {
            deltaX = 1.585f;
        }
        else if (n > 21 && n < 30)
        {
            deltaX = 1.23f;
        }
        else if (n == 31)
        {
            deltaY = -1.585f;
        }
        else if (n > 31 && n < 40)
        {
            deltaY = -1.23f;
        }
       
        //Inserts waypoint position into the array
        waypointPositions[n] = new Vector3(previousX + deltaX, previousY + deltaY, 1f);
        previousX = waypointPositions[n].x;
        previousY = waypointPositions[n].y;*/
    }
}