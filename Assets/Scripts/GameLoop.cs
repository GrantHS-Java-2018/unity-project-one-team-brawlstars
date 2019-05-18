using System.Collections;
using System.Collections.Generic;
using TileScripts;
using UnityEditor;
using UnityEngine;
using UnityEngine.Experimental.Audio.Google;

public class GameLoop : MonoBehaviour
{
        public static GameObject tileManager;
        
        private static Player _currentPlayer;
        
        private static int _currentDieSum;

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
