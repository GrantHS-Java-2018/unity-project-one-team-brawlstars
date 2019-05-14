using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TileScripts.PurchasableTiles
{
    public abstract class PropertyTile : Tile
    {
        protected Player Owner;
        private int _purchasePrice;
        private int _mortgageDividend;
        private bool _isMortgaged;

        public void Buy()
        {
            GameLoop.GetCurrentPlayer().Charge(_purchasePrice);
            Owner = GameLoop.GetCurrentPlayer();
        }
        
        public void ChangeMortgage()
        {
            if (!_isMortgaged)
            {
                Owner.Pay(_mortgageDividend);
                _isMortgaged = true;
            }
            else
            {
                Owner.Charge(_mortgageDividend + _mortgageDividend / 10);
            } 
        }
        
        protected abstract void Rent();

        public override void DoTileAction()
        {
            
        }
    }
}
