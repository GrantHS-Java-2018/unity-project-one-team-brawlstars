using System;
using System.Collections;
using System.Collections.Generic;
using TileScripts;
using UnityEngine;

namespace TileScripts.SpecialTiles
{

    public class TaxTile : Tile
    {
        private int _taxAmount;
        
        
        public override void SetUpTile(String incomingTileName, Vector3 incomingTileWaypoint, int[] incomingTileValues)
        {
            TileName = incomingTileName;
            TileWaypoint = incomingTileWaypoint;
            _taxAmount = incomingTileValues[0];
        }

        public override void DoTileAction()
        {
            GameLoop.GetCurrentPlayer().Charge(_taxAmount);
        }
    }
}