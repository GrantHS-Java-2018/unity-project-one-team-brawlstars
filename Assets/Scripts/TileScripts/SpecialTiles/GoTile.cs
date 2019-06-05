using System;
using System.Collections;
using System.Collections.Generic;
using TileScripts;
using UnityEngine;

namespace TileScripts.SpecialTiles
{

    public class GoTile : Tile
    {
        public override void SetUpTile(int incomingTileIndex, String incomingTileName, Vector3 incomingTilePosition, Sprite incomingTileSprite, int[] incomingTileValues)
        {
            TileIndex = incomingTileIndex;
            tileName = incomingTileName;
            TilePosition = incomingTilePosition;
        }

        public override void DoTileAction()
        {
            
        }
    }
}