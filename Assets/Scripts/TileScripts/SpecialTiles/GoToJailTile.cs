using System;
using System.Collections;
using System.Collections.Generic;
using PlayerSetupScripts;
using TileScripts;
using UnityEngine;

namespace TileScripts.SpecialTiles
{
    public class GoToJailTile : Tile
    {
        private PlayerMovement _playerMovement;
        
        public override void SetUpTile(int incomingTileIndex, String incomingTileName, Vector3 incomingTilePosition, Sprite incomingTileSprite, int[] incomingTileValues)
        {
            TileIndex = incomingTileIndex;
            tileName = incomingTileName;
            TilePosition = incomingTilePosition;

            _playerMovement = GameObject.Find("PlayerMovement").GetComponent<PlayerMovement>();
        }

        public override void DoTileAction()
        {
            _playerMovement.SendPlayerToJail();
        }
    }
}