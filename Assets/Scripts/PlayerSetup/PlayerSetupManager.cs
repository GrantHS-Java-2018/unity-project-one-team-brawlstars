using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PlayerSetup
{
    public class PlayerSetupManager : MonoBehaviour
    {
        [SerializeField] private Dropdown playerCountDropdown;        
        
        private Player[] _players;
        
        public Player[] GetPlayers()
        {
            return _players;
        }
            
        public void InitializePlayers()
        {
            _players = new Player[playerCountDropdown.value + 2];
        }
    }
}