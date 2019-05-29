using System.Collections;
using System.Collections.Generic;
using PlayerSetupScripts;
using TileScripts;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public static class GameLoop
{
        private static Button _endTurnButton;

        private static Button _rollButton;
        
        private static GameObject _playerHolster;
        
        private static Player _currentPlayer;
        
        private static int _currentDieSum;

        private static Text _actionPromptText;
        
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
                _rollButton = GameObject.Find("RollButton").GetComponent<Button>();
                _endTurnButton = GameObject.Find("EndTurnButton").GetComponent<Button>();
                
                StartTurn(GetNextPlayer());
        }
        
        private static void StartTurn(Player nextPlayer)
        {
                /*_endTurnButton.interactable = false;*/ //uncomment this when we have a way to determine if a turn is over and reactivate the end turn button
                _currentDieSum = 0;
                _rollButton.interactable = true;
                _currentPlayer = nextPlayer;
                _actionPromptText.text = "Player " + nextPlayer.GetNumber() + "'s turn";
        }

        public static void EndTurn()
        {
                StartTurn(GetNextPlayer());
        }

        private static Player GetNextPlayer()
        {
                Player[] playerArray = PlayerManager.GetPlayers();
                if (_currentPlayer.GetNumber() == playerArray.Length)
                {
                        return playerArray[0];
                }
                else
                {
                        return playerArray[_currentPlayer.GetNumber()];
                }
        }
}
