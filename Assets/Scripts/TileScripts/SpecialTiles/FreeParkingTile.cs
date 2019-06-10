﻿using System;
using System.Collections;
using System.Collections.Generic;
using TileScripts;
using UnityEngine;

namespace TileScripts.SpecialTiles
{
    public class FreeParkingTile : Tile
    {
        private static int _payout = 200;
        
        public override void SetUpTile(int incomingTileIndex, String incomingTileName, Vector3 incomingTilePosition, Sprite incomingTileSprite, int[] incomingTileValues)
        {
            TileIndex = incomingTileIndex;
            tileName = incomingTileName;
            TilePosition = incomingTilePosition;
        }
        
        public override void DoTileAction()
        {
                GameLoop.GetCurrentPlayer().Pay(_payout);
                _payout = 200;
        }
        public static void AddToParkingPayout(int taxAmount)
        {
            _payout += taxAmount;
        }
    }     
}