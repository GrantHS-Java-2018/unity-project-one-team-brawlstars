using System;
using System.Collections;
using System.Collections.Generic;
using TileScripts;
using UnityEngine;

namespace TileScripts.SpecialTiles
{
    public class CardDeckTile : Tile
    {
        public override void SetUpTile(String incomingTileName, Vector3 incomingTileWaypoint, int[] incomingTileValues)
        {
            tileName = incomingTileName;
            TileWaypoint = incomingTileWaypoint;
            //Here needs to go a way of setting the deck to either community chest or chance first value 0 is chance, 1 is community chest
            //To do this, maybe create a deck class and a gameObject that holds a deck array with 2 deck scripts with indexes 0 and 1
            //Decks should have card array and shuffle and deal methods
            //Cards should have sprites that pop up and associated card methods
        }
        
        public override void DoTileAction()
        {
                
        }
    }
}