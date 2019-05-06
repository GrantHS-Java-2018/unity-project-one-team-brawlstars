using System.Collections;
using System.Collections.Generic;
using GameInformation;
using UnityEngine;

namespace TileScripts
{
    public class TileManager : MonoBehaviour
    {
        private Tile[] _gameTiles = new Tile[40];

        private void Start()
        {
            for (int n = 0; n < 40; n++)
            {
                _gameTiles[n].setUpTile(TileInformation);
            }
        }
    }
}