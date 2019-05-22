using System.Collections;
using System.Collections.Generic;
using PlayerSetupScripts;
using TileScripts;
using UnityEngine;

public class GameSetup : MonoBehaviour
{
    void Start()
    {
        GameLoop.SetUpGameLoop();
        TileManager.SetUpTiles();
        PlayerManager.PlacePlayersOnBoard();
    }
}
