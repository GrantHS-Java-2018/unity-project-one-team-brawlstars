using System.Collections;
using System.Collections.Generic;
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

        private static GameObject _sceneController;

        //Initializes the player array in the beginning of the game
        public static void SetUpPlayerManager()
        {
            _tokenSelectionCanvas = GameObject.Find("TokenSelectionCanvas");
            _playerCountDropdown = GameObject.Find("Dropdown").GetComponent<Dropdown>();
            _sceneController = GameObject.Find("SceneController");
            
            _players = new Player[_playerCountDropdown.value + 2];
            for (int n = 0; n < _playerCountDropdown.value + 2; n++)
            {
                _players[n] = _sceneController.AddComponent<Player>();
            }
        }
        
        //Simply assigns a token to a player in the start screen (triggers from TokenClickDetector)
        public static void AssignToken(Sprite assignedToken)
        {
            int playerIndex = 0;
             //Exists to keep track of player that we are assigning token sprite too
            _players[playerIndex].SetPlayerToken(assignedToken); 
            playerIndex += 1;
            if (playerIndex < _playerCountDropdown.value + 2)
            {
                _tokenSelectionCanvas.GetComponentInChildren<Text>().text = "Player " + (playerIndex + 1) + ", pick a token"; //Changes prompt text to prompt next player to choose token
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