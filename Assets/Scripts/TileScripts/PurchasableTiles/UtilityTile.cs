using System.Collections;
using System.Collections.Generic;
using TileScripts.PurchasableTiles;
using UnityEngine;

namespace TileScripts.PurchasableTiles
{
    public class UtilityTile : PropertyTile
    {
        protected override void Rent()
        {
            int rentMoney = Owner.GetRailroadsOwned() * GameLoop.GetCurrentDieSum();
            
            GameLoop.GetCurrentPlayer().Charge(rentMoney);
            Owner.Pay(rentMoney);
        }
    }
}