using System.Collections;
using System.Collections.Generic;
using GameInformation;
using PlayerSetupScripts;
using TileScripts;
using UnityEngine;

public class GameSetup : MonoBehaviour
{
    void Start()
    {
        PopupManager.SetUpPopupManager();
        TileInformation.SetUpTileInformation();
        TileManager.SetUpTiles();
        PlayerManager.PlacePlayersOnBoard();
        GameLoop.SetUpGameLoop();
    }
}
