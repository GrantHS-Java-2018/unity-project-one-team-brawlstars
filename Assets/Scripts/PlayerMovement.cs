using System.Collections;
using System.Collections.Generic;
using PlayerSetupScripts;
using TileScripts;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Player[] playerArray;

    private bool _moveAllowed;
    
    void Start()
    {
        playerArray = PlayerManager.GetPlayers();
        //needs to somehow get ahold of player array so that I can see it in Unity editor serialized
    }

    public void MovePlayer()
    {
        if (_moveAllowed)
        {
            StartCoroutine(GameLoop.GetCurrentPlayer().MoveCoroutine(GameLoop.GetCurrentDieSum()));
            _moveAllowed = false;
        }
    }

    public void MoveFinished()
    {
        _moveAllowed = true;
    }
}
