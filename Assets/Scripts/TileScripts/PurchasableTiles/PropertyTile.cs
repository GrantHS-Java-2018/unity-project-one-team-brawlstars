using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TileScripts.PurchasableTiles
{
    public abstract class PropertyTile : Tile
    {
        protected Player Owner;
        private int _purchasePrice;
        private int _mortgagePrice;

        public void Buy()
        {
            GameLoop.GetCurrentPlayer().Charge(_purchasePrice);
            Owner = GameLoop.GetCurrentPlayer();
        }
        
        public void Mortgage()
        {
            
            
        }
        
        protected abstract void Rent()
        {
            
        }

        public override void DoTileAction()
        {
            if (Owner == null)
            {
                
            }
            else
            {
                Rent();
            }
        }
    }
}
