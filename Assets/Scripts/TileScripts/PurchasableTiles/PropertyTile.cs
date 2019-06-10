using System;
using System.Collections;
using System.Collections.Generic;
using GameInformation;
using UnityEngine;
using UnityEngine.UI;

namespace TileScripts.PurchasableTiles
{
    public abstract class PropertyTile : Tile
    {
        [SerializeField] protected Player Owner;
        [SerializeField] protected int PurchasePrice;
        protected int MortgageDividend;
        private bool _isMortgaged;
        protected Sprite DeedSprite;


        public virtual void Buy()
        {
            GameLoop.GetCurrentPlayer().Charge(PurchasePrice);
            Owner = GameLoop.GetCurrentPlayer();
            PlayerInformationManager.UpdatePlayerInfo();
        }
        
        public void ChangeMortgage()
        {
            if (!_isMortgaged)
            {
                Owner.Pay(MortgageDividend);
                _isMortgaged = true;
            }
            else
            {
                Owner.Charge(MortgageDividend + MortgageDividend / 10);
            } 
        }
        
        protected abstract void Rent();
        public abstract override void SetUpTile(int incomingTileIndex, String incomingTileName, Vector3 incomingTilePosition, Sprite incomingTileSprite, int[] incomingTileValues);
        public override void DoTileAction()
        {
            if (Owner == null)
            {
                PopupManager.MakeNewPopUp(1, TileIndex, DeedSprite);
            }
            else
            {
                Rent();
            }
        }
    }
}
