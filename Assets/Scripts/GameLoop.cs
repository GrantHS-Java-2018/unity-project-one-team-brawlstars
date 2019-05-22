using System.Collections;
using System.Collections.Generic;
using PlayerSetupScripts;
using TileScripts;
using UnityEditor;
using UnityEngine;
using UnityEngine.Experimental.Audio.Google;

public static class GameLoop
{        
        private static GameObject _playerHolster;
        
        private static Player _currentPlayer;
        
        private static int _currentDieSum;

        public static void SetUpGameLoop()
        {
                _playerHolster = GameObject.Find("PlayerHolster");
        }

        public static GameObject GetPlayerHolster()
        {
                return _playerHolster;
        }
        
        public static Player GetCurrentPlayer()
        {
                return _currentPlayer;
        }

        public static int GetCurrentDieSum()
        {
                return _currentDieSum;
        }
        
        private static void StartTurn(Player nextPlayer)
        {
                _currentPlayer = nextPlayer;
        }
}
