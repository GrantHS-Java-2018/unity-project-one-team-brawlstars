using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;


namespace TileScripts.PurchasableTiles
{
    public class RailroadTile : PropertyTile
    {
        protected override void Rent()
        {
            int rentMoney = Owner.GetRailroadsOwned() * 25;
            
            GameLoop.GetCurrentPlayer().Charge(rentMoney);
            Owner.Pay(rentMoney);
        }
    }
}