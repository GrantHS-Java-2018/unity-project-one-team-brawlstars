using System;
using System.Collections;
using System.Collections.Generic;
using TileScripts.PurchasableTiles;
using UnityEngine;

namespace TileScripts.PurchasableTiles
{
    public class UtilityTile : PropertyTile
    {
        public override void SetUpTile(String incomingTileName, Vector3 incomingTileWaypoint, int[] incomingTileValues)
        {
            TileName = incomingTileName;
            TileWaypoint = incomingTileWaypoint;
            PurchasePrice = incomingTileValues[0];
            MortgageDividend = incomingTileValues[1];
        }
        protected override void Rent()
        {
            int rentMoney = Owner.GetRailroadsOwned() * GameLoop.GetCurrentDieSum();
            
            GameLoop.GetCurrentPlayer().Charge(rentMoney);
            Owner.Pay(rentMoney);
        }
    }
}