using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TileScripts.PurchasableTiles
{
    public class RealEstateTile : PropertyTile
    {
        private int _buyPrice;

        private int _housePrice;
        
        private int _houses;
        
        private int[] _rents = new int[6];
        
        private int _mortgageDividend;
        
        protected override void Rent()
        {
            int rentMoney = _rents[_houses];
            
            GameLoop.GetCurrentPlayer().Charge(rentMoney);
            Owner.Pay(rentMoney);
        }
    }
}