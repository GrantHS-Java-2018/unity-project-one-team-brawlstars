using System.Collections;
using System.Collections.Generic;
using TileScripts;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngineInternal;

namespace PlayerSetupScripts
{
    public static class PlayerManager
    {
        private static Dropdown _playerCountDropdown; //Dropdown for selecting number of players

        private static Player[] _players; //Main array to hold players

        private static GameObject _tokenSelectionCanvas;//Canvas on which tokens are clicked and selected by players

        private static int _playerIndex;

        //Initializes the player array in the beginning of the game
        public static void SetUpPlayerManager(GameObject incomingTokenSelectionCanvas)
        {
            _tokenSelectionCanvas = incomingTokenSelectionCanvas;
            _playerCountDropdown = GameObject.Find("Dropdown").GetComponent<Dropdown>();
            
            _players = new Player[_playerCountDropdown.value + 2];
            for (int n = 0; n < _playerCountDropdown.value + 2; n++)
            {
                _players[n] = new Player();
            }
        }

        public static void PlacePlayersOnBoard()
        {
            for (int n = 0; n < _players.Length; n++)
            {
                _players[n].SetTileManager();
                _players[n].SetNumber(n + 1);
                _players[n].PlaceOnBoard();
            }
        }
        
        //Simply assigns a token to a player in the start screen (triggers from TokenClickDetector)
        public static void AssignToken(Sprite assignedToken)
        {
             //Exists to keep track of player that we are assigning token sprite too
            _players[_playerIndex].SetPlayerToken(assignedToken); 
            _playerIndex += 1;
            if (_playerIndex < _playerCountDropdown.value + 2)
            {
                _tokenSelectionCanvas.GetComponentInChildren<Text>().text = "Player " + (_playerIndex + 1) + ", pick a token"; //Changes prompt text to prompt next player to choose token
            }
            else //Loads main game scene
            {
                SceneManager.LoadScene("BoardScene");
            }     
        }

        //Returns ever-changing player array so game can change player information
        public static Player[] GetPlayers()
        {
            return _players;
        }
    }
}