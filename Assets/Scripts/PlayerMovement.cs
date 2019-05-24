using System.Collections;
using System.Collections.Generic;
using PlayerSetupScripts;
using TileScripts;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Player[] playerArray;    
    void Start()
    {
        playerArray = PlayerManager.GetPlayers();
        //needs to somehow get ahold of player array so that I can see it in Unity editor serialized
    }

    public void MovePlayer()
    {
        StartCoroutine(GameLoop.GetCurrentPlayer().MoveCoroutine(3)); //Replace dicesum with GameLoop.currentDieSum when finished, and playerarray[1] with GameLoop.currentPlayer when finished
    }
}
