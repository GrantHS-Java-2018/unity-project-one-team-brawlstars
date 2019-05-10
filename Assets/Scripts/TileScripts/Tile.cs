using System;
using System.Collections;
using System.Collections.Generic;
using GameInformation;
using UnityEngine;

namespace TileScripts
{
    public abstract class Tile
    {
        protected String TileName;
        protected Vector3 TileWaypoint;

        public abstract void SetUpTile(String incomingTileName, Vector3 incomingTileWaypoint, int[] incomingTileValues);
        public abstract void DoTileAction();
    }
}