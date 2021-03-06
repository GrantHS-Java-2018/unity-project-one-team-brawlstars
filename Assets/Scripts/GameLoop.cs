﻿using System.Collections;
using System.Collections.Generic;
using PlayerSetupScripts;
using TileScripts;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public static class GameLoop
{
        private static bool _endTurnButtonOn;

        private static bool _rollButtonOn;

        private static Button[] _gameButtons;

        private static bool[] _gameButtonsOn;
        
        private static GameObject _playerHolster;
        
        private static Player _currentPlayer;
        
        private static int _currentDieSum;

        private static Text _actionPromptText;

        private static bool _pair;

        private static int _pairCount;

        private static GameObject _playerMovement;
        
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
                _playerMovement = GameObject.Find("PlayerMovement");
                
                _gameButtons = new Button[5];
                _gameButtons[0] = GameObject.Find("RollButton").GetComponent<Button>(); //Roll button
                _gameButtons[1] = GameObject.Find("EndTurnButton").GetComponent<Button>(); //End turn button
                //add game buttons as they are added to the UI

                _gameButtonsOn = new bool[5];
                
                StartTurn(_currentPlayer);
        }

        public static void ReportDieRolls(int roll, bool isPair)
        {
                _currentDieSum = roll;
                _pair = isPair;
                if (_pair)
                {
                        _pairCount++;     
                }
                if (_pairCount > 2)
                {
                        _playerMovement.GetComponent<PlayerMovement>().SendPlayerToJail();
                }
                else
                {
                        _playerMovement.GetComponent<PlayerMovement>().MovePlayer();
                        if (!_pair)
                        {
                                _gameButtons[0].interactable = false;
                        }     
                }
        }
        
        private static void StartTurn(Player nextPlayer)
        {
                _currentDieSum = 0;
                _pairCount = 0;
                _currentPlayer = nextPlayer;
                if (!_currentPlayer.CheckIfJailed(true))
                {
                        _gameButtons[0].interactable = true;
                }
                else
                {
                        PopupManager.MakeNewPopUp(2, _currentPlayer.GetCurrentWaypoint(), Resources.Load<Sprite>("Sprites/JailSprite"));//set this up!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                }
                
                _actionPromptText.text = "Player " + nextPlayer.GetNumber() + "'s turn";
        }

        public static void EnableRollButton()
        {
                _gameButtons[0].interactable = true;
                Debug.Log("Roll Button Enabled");
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

        public static void DeactivateGameButtons()
        {
                for (int n = 0; n < 2; n++)
                {
                        _gameButtonsOn[n] = _gameButtons[n].IsInteractable();
                }

                if (_currentPlayer.CheckIfJailed(false))
                {
                        _gameButtonsOn[0] = true;
                }
                
                for (int n = 0; n < 2; n++)
                {
                        _gameButtons[n].interactable = false;
                }
        }

        public static void ActivateGameButtons()
        {
                for (int n = 0; n < 2; n++)
                {
                        _gameButtons[n].interactable = _gameButtonsOn[n];
                }
        }
}
