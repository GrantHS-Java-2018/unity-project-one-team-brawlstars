using System.Collections;
using System.Collections.Generic;
using PlayerSetupScripts;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace PlayerScripts
{
    public class PlayerManager : MonoBehaviour
    {   
        [SerializeField] private Player[] players;
        
        
        void Start()
        {
            players = GameObject.Find("TemporaryPlayerHolster").GetComponent<PlayerSetupManager>()
                .GetPlayersFromStart();
            Destroy(GameObject.Find("TemporaryPlayerHolster"));
            //Make sure that players are still usable in the in-game playerholster object
            
        }
    }
}


