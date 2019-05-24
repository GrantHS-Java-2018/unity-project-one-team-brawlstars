using System.Collections;
using System.Collections.Generic;
using PlayerSetupScripts;
using TileScripts;
using UnityEngine;

public class GameSetup : MonoBehaviour
{
    void Start()
    {
        TileManager.SetUpTiles();
        GameLoop.SetUpGameLoop();
        PlayerManager.PlacePlayersOnBoard();
    }
}
