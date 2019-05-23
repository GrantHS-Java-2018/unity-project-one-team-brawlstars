using System;
using System.Collections;
using System.Collections.Generic;
using GameInformation;
using UnityEngine;
using UnityEngine.Serialization;

namespace TileScripts
{
    [Serializable]
    public abstract class Tile
    {
        [FormerlySerializedAs("TileName")] public String tileName;
        protected Vector3 TilePosition;

        public Vector3 GetTilePosition()
        {
            return TilePosition;
        }

        public abstract void SetUpTile(String incomingTileName, Vector3 incomingTileWaypoint, int[] incomingTileValues);
        public abstract void DoTileAction();
    }
}