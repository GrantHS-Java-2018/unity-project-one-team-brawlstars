using System.Collections;
using System.Collections.Generic;
using PlayerSetupScripts;
using TileScripts;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public static class GameLoop
{        
        private static GameObject _playerHolster;
        
        private static Player _currentPlayer;
        
        private static int _currentDieSum;

        private static Text _actionPromptText;

        private static bool endTurn = false;

        public static void EndTurn()
        {
                endTurn = true;
        }

        public static Player GetCurrentPlayer()
        {
                return _currentPlayer;
        }

        public static int GetCurrentDieSum()
        {
                return _currentDieSum;
        }

        public static void SetUpGameLoop()
        {
                _actionPromptText = GameObject.Find("PromptTextCanvas").GetComponentInChildren<Text>();
                _currentPlayer = PlayerManager.GetPlayers()[0];
                
                StartGameLoop();
        }
        
        private static void StartTurn(Player nextPlayer)
        {
                _currentPlayer = nextPlayer;
                _currentDieSum = 0;
                _actionPromptText.text = "Player " + nextPlayer.GetNumber() + "'s turn";
        }

        private static Player GetNextPlayer()
        {
                Player[] playerArray = PlayerManager.GetPlayers();
                if (_currentPlayer.GetNumber() + 1 == playerArray.Length)
                {
                        return playerArray[0];
                }
                else
                {
                        return playerArray[_currentPlayer.GetNumber() + 1];
                }
        }
        
        public static void StartGameLoop()
        {
                StartTurn(GetNextPlayer());
                endTurn = false;
                //put something here to make sure that the game waits till the turn is over to start the next turn
                ////This is an infinite loop until we put a block here that limits it to only go after a player ends their turn
              
        }
}
