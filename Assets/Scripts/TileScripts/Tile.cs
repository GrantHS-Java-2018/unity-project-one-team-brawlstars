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
        protected int TileIndex;

        public Vector3 GetTilePosition()
        {
            return TilePosition;
        }

        public abstract void SetUpTile(int incomingTileIndex, String incomingTileName, Vector3 incomingTileWaypoint, Sprite tileSprite, int[] incomingTileValues);
        public abstract void DoTileAction();
    }
}