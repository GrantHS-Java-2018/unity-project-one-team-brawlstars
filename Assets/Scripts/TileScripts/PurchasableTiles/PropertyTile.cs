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
        protected Player Owner;
        protected int PurchasePrice;
        protected int MortgageDividend;
        private bool _isMortgaged;

        public void Buy()
        {
            GameLoop.GetCurrentPlayer().Charge(PurchasePrice);
            Owner = GameLoop.GetCurrentPlayer();
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
        public abstract override void SetUpTile(String incomingTileName, Vector3 incomingTileWaypoint, int[] incomingTileValues);
        public override void DoTileAction()
        {
            
        }
    }
}
