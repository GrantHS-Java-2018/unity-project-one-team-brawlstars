using System.Collections;
using System.Collections.Generic;
using CardScripts;
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
        CardInformation.SetUpCardInformation();
        CardManager.SetUpCardManager();
        PlayerManager.PlacePlayersOnBoard();
        GameLoop.SetUpGameLoop();
    }
}
