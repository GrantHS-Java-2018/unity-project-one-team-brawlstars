using System;
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
        
        public override void SetUpTile(String incomingTileName, Vector3 incomingTilePosition, int[] incomingTileValues)
        {
            tileName = incomingTileName;
            TilePosition = incomingTilePosition;
            PurchasePrice = incomingTileValues[0];
            MortgageDividend = incomingTileValues[1];
            _housePrice = incomingTileValues[2];
            for (int n = 0; n < 5; n++)
            {
                _rents[n] = incomingTileValues[n + 3];
            }
        }
        
        protected override void Rent()
        {
            int rentMoney = _rents[_houses];
            
            GameLoop.GetCurrentPlayer().Charge(rentMoney);
            Owner.Pay(rentMoney);
        }
    }
}