using System;
using System.Collections;
using System.Collections.Generic;
using GameInformation;
using UnityEngine;
using UnityEngine.Analytics;


namespace TileScripts.PurchasableTiles
{
    public class RailroadTile : PropertyTile
    {
        public override void SetUpTile(String incomingTileName, Vector3 incomingTilePosition, int[] incomingTileValues)
        {
            tileName = incomingTileName;
            TilePosition = incomingTilePosition;
            PurchasePrice = incomingTileValues[0];
            MortgageDividend = incomingTileValues[1];
        }
        protected override void Rent() 
        {
            int rentMoney = Owner.GetRailroadsOwned() * 25;
            
            GameLoop.GetCurrentPlayer().Charge(rentMoney);
            Owner.Pay(rentMoney);
        }
    }
}