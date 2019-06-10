using System;
using System.Collections;
using System.Collections.Generic;
using CardScripts;
using TileScripts;
using UnityEngine;

namespace TileScripts.SpecialTiles
{
    public class CardDeckTile : Tile
    {
        private static Card _currentCard;
        
        private bool _isChance;
        
        public static Card GetCurrentCard()
        {
            return _currentCard;
        }
        
        public override void SetUpTile(int incomingTileIndex, String incomingTileName, Vector3 incomingTilePosition, Sprite incomingTileSprite, int[] incomingTileValues)
        {
            TileIndex = incomingTileIndex;
            tileName = incomingTileName;
            TilePosition = incomingTilePosition;
            if (incomingTileValues[0] == 0)
            {
                _isChance = true;
            }
        }
        
        public override void DoTileAction()
        {
            if (_isChance)
            {
                _currentCard = CardManager.DealChance();
            }
            else
            {
                _currentCard = CardManager.DealCommunityChest();
            }
            
            PopupManager.MakeNewPopUp(3, TileIndex, _currentCard.GetCardSprite());
        }
    }
}