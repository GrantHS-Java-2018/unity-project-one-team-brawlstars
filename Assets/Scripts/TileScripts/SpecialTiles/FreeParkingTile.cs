using System;
using System.Collections;
using System.Collections.Generic;
using TileScripts;
using UnityEngine;

namespace TileScripts.SpecialTiles
{
    public class FreeParkingTile : Tile
    {
        private int _payout = 200;
        
        public override void SetUpTile(String incomingTileName, Vector3 incomingTilePosition, int[] incomingTileValues)
        {
            tileName = incomingTileName;
            TilePosition = incomingTilePosition;
        }
        
        public override void DoTileAction()
        {
                GameLoop.GetCurrentPlayer().Pay(_payout);
                _payout = 200;
        }
        public void AddToParkingPayout(int taxAmount)
        {
            _payout += taxAmount;
        }
    }     
}