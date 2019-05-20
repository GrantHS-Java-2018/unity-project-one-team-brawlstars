using System;
using System.Collections;
using System.Collections.Generic;
using TileScripts;
using UnityEngine;

namespace TileScripts.SpecialTiles
{
    public class GoToJailTile : Tile
    {
        public override void SetUpTile(String incomingTileName, Vector3 incomingTileWaypoint, int[] incomingTileValues)
        {
            TileName = incomingTileName;
            TileWaypoint = incomingTileWaypoint;
        }

        public override void DoTileAction()
        {
            GameLoop.GetCurrentPlayer().GoToJail();
        }
    }
}