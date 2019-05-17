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
    public class TileManager : MonoBehaviour
    {
         public Tile[] gameTiles = new Tile[40];
        
        private void Start()
        {
            gameTiles[0] = new GoTile();
            gameTiles[1] = new RealEstateTile();
            gameTiles[2] = new CardDeckTile();
            gameTiles[3] = new RealEstateTile();
            gameTiles[4] = new TaxTile();
            gameTiles[5] = new RailroadTile();
            gameTiles[6] = new RealEstateTile();
            gameTiles[7] = new CardDeckTile();
            gameTiles[8] = new RealEstateTile();
            gameTiles[9] = new RealEstateTile();
            gameTiles[10] = new InJailTile();
            gameTiles[11] = new RealEstateTile();
            gameTiles[12] = new UtilityTile();
            gameTiles[13] = new RealEstateTile();
            gameTiles[14] = new RealEstateTile();
            gameTiles[15] = new RailroadTile();
            gameTiles[16] = new RealEstateTile();
            gameTiles[17] = new CardDeckTile();
            gameTiles[18] = new RealEstateTile();
            gameTiles[19] = new RealEstateTile();
            gameTiles[20] = new FreeParkingTile();
            gameTiles[21] = new RealEstateTile();
            gameTiles[22] = new CardDeckTile();
            gameTiles[23] = new RealEstateTile();
            gameTiles[24] = new RealEstateTile();
            gameTiles[25] = new RailroadTile();
            gameTiles[26] = new RealEstateTile();
            gameTiles[27] = new RealEstateTile();
            gameTiles[28] = new UtilityTile();
            gameTiles[29] = new RealEstateTile();
            gameTiles[30] = new GoToJailTile();
            gameTiles[31] = new RealEstateTile();
            gameTiles[32] = new RealEstateTile();
            gameTiles[33] = new CardDeckTile();
            gameTiles[34] = new RealEstateTile();
            gameTiles[35] = new RailroadTile();
            gameTiles[36] = new CardDeckTile();
            gameTiles[37] = new RealEstateTile();
            gameTiles[38] = new TaxTile();
            gameTiles[39] = new RealEstateTile();

            for (int n = 0; n < 40; n++)
            {
                var tileInformationHolder = TileInformation.GetTileInformation(n);
                gameTiles[n].SetUpTile(tileInformationHolder.Item1, tileInformationHolder.Item2, tileInformationHolder.Item3);
            }
        }
    }
}