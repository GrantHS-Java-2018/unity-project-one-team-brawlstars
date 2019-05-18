using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngineInternal;

namespace PlayerSetupScripts
{
    public class PlayerManager : MonoBehaviour
    {
        [SerializeField] private Dropdown playerCountDropdown; //Dropdown for selecting number of players

        [SerializeField] private Player[] players; //Main array to hold players

        [SerializeField] private GameObject tokenSelectionCanvas;//Canvas on which tokens are clicked and selected by players

        private int _playerIndex;
        
        //Simply makes it so this game object will not go away, so we can keep accessing array
        private void Awake()
        {
            DontDestroyOnLoad(this);
        }

        //Initializes the player array in the beginning of the game
        public void InitializePlayers()
        {
            players = new Player[playerCountDropdown.value + 2];
            for (int n = 0; n < playerCountDropdown.value + 2; n++)
            {
                players[n] = gameObject.AddComponent<Player>();
            }
        }
        
        //Simply assigns a token to a player in the start screen (triggers from TokenClickDetector)
        public void AssignToken(Sprite assignedToken)
        {
             //Exists to keep track of player that we are assigning token sprite too
            players[_playerIndex].SetPlayerToken(assignedToken); 
            _playerIndex += 1;
            if (_playerIndex < playerCountDropdown.value + 2)
            {
                tokenSelectionCanvas.GetComponentInChildren<Text>().text = "Player " + (_playerIndex + 1) + ", pick a token"; //Changes prompt text to prompt next player to choose token
            }
            else //Loads main game scene
            {
                SceneManager.LoadScene("BoardScene");
            }     
        }

        //Returns ever-changing player array so game can change player information
        public Player[] GetPlayers()
        {
            return players;
        }

        
    }
}