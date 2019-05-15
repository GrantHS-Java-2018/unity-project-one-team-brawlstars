using System;
using System.Collections;
using System.Collections.Generic;
using TileScripts;
using UnityEngine;

public class GoToJailTile : Tile
{
    public override void SetUpTile(String incomingTileName, Vector3 incomingTileWaypoint, int[] incomingTileValues)
    {
        TileName = incomingTileName;
    }
    
    public override void DoTileAction()
    {
            
    }
}
