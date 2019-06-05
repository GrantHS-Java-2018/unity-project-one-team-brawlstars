using System;
using System.Collections;
using System.Collections.Generic;
using GameInformation;
using TileScripts.PurchasableTiles;
using TileScripts.SpecialTiles;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace TileScripts
{
    public static class TileManager 
    {
         private static Tile[] _gameTiles = new Tile[40];

         public static Tile GetTile(int tileIndex)
         {
             return _gameTiles[tileIndex];
         }

         public static Tile[] GetAllTiles()
         {
             return _gameTiles;
         }
         
        public static void SetUpTiles()
        {
            _gameTiles[0] = new GoTile();
            _gameTiles[1] = new RealEstateTile();
            _gameTiles[2] = new CardDeckTile();
            _gameTiles[3] = new RealEstateTile();
            _gameTiles[4] = new TaxTile();
            _gameTiles[5] = new RailroadTile();
            _gameTiles[6] = new RealEstateTile();
            _gameTiles[7] = new CardDeckTile();
            _gameTiles[8] = new RealEstateTile();
            _gameTiles[9] = new RealEstateTile();
            _gameTiles[10] = new InJailTile();
            _gameTiles[11] = new RealEstateTile();
            _gameTiles[12] = new UtilityTile();
            _gameTiles[13] = new RealEstateTile();
            _gameTiles[14] = new RealEstateTile();
            _gameTiles[15] = new RailroadTile();
            _gameTiles[16] = new RealEstateTile();
            _gameTiles[17] = new CardDeckTile();
            _gameTiles[18] = new RealEstateTile();
            _gameTiles[19] = new RealEstateTile();
            _gameTiles[20] = new FreeParkingTile();
            _gameTiles[21] = new RealEstateTile();
            _gameTiles[22] = new CardDeckTile();
            _gameTiles[23] = new RealEstateTile();
            _gameTiles[24] = new RealEstateTile();
            _gameTiles[25] = new RailroadTile();
            _gameTiles[26] = new RealEstateTile();
            _gameTiles[27] = new RealEstateTile();
            _gameTiles[28] = new UtilityTile();
            _gameTiles[29] = new RealEstateTile();
            _gameTiles[30] = new GoToJailTile();
            _gameTiles[31] = new RealEstateTile();
            _gameTiles[32] = new RealEstateTile();
            _gameTiles[33] = new CardDeckTile();
            _gameTiles[34] = new RealEstateTile();
            _gameTiles[35] = new RailroadTile();
            _gameTiles[36] = new CardDeckTile();
            _gameTiles[37] = new RealEstateTile();
            _gameTiles[38] = new TaxTile();
            _gameTiles[39] = new RealEstateTile();

            for (int n = 0; n < 40; n++)
            {
                var tileInformationHolder = TileInformation.GetTileInformation(n);
                _gameTiles[n].SetUpTile(tileInformationHolder.Item1, tileInformationHolder.Item2, tileInformationHolder.Item3, tileInformationHolder.Item4, tileInformationHolder.Item5);
            }
        }
    }
}