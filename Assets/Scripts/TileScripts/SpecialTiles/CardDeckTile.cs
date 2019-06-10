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

            //Here needs to go a way of setting the deck to either community chest or chance first value 0 is chance, 1 is community chest
            //To do this, maybe create a deck class and a gameObject that holds a deck array with 2 deck scripts with indexes 0 and 1
            //Decks should have card array and shuffle and deal methods
            //Cards should have sprites that pop up and associated card methods
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