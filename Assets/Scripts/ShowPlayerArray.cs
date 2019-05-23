using System.Collections;
using System.Collections.Generic;
using PlayerSetupScripts;
using TileScripts;
using UnityEngine;

public class ShowPlayerArray : MonoBehaviour
{
    [SerializeField] private Player[] playerArray;
    void Start()
    {
        playerArray = PlayerManager.GetPlayers();
        //needs to somehow get ahold of player array so that I can see it in Unity editor serialized
    }

    public void MovePlayer()
    {
        StartCoroutine(playerArray[1].MoveCoroutine(3));
    }
}
