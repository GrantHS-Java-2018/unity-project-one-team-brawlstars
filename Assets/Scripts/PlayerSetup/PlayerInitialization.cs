using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PlayerSetup
{
    public class PlayerInitialization : MonoBehaviour
    {
        
        [SerializeField] private Dropdown choiceDropdown;

        private Player[] _players;

        public Player[] GetPlayers()
        {
            return _players;
        }
            
        public void InitializePlayers()
        {
            _players = new Player[choiceDropdown.value + 2];
        }
    }
}