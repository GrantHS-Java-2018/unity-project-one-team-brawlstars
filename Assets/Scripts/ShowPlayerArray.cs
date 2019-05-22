using System.Collections;
using System.Collections.Generic;
using PlayerSetupScripts;
using UnityEngine;

public class ShowPlayerArray : MonoBehaviour
{
    [SerializeField] private Player[] playerArray;
    void Start()
    {
        //needs to somehow get ahold of player array so that I can see it in Unity editor serialized
    }
}
