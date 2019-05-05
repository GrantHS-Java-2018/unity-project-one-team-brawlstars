using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework.Internal;
using UnityEngine;

namespace TileScripts
{
    public abstract class Tile
    {
        private String _tileName;
        private Vector3 _waypointLocation;

        public abstract void DoTileAction()
        {
            
        }
    }
}