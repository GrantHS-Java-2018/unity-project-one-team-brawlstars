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
        
        
        public override void SetUpTile(int incomingTileIndex, String incomingTileName, Vector3 incomingTilePosition, Sprite incomingTileSprite, int[] incomingTileValues)
        {
            TileIndex = incomingTileIndex;
            tileName = incomingTileName;
            TilePosition = incomingTilePosition;
            _taxAmount = incomingTileValues[0];
        }

        public override void DoTileAction()
        {
            GameLoop.GetCurrentPlayer().Charge(_taxAmount);
        }
    }
}