using System.Collections;
using System.Collections.Generic;
using PlayerSetupScripts;
using TileScripts;
using UnityEditor;
using UnityEngine;
using UnityEngine.Experimental.Audio.Google;

public class GameLoop : MonoBehaviour
{
        public static GameObject tileManager;
        
        private GameObject _playerManager;
        
        private static Player _currentPlayer;
        
        private static int _currentDieSum;

        

        public void Start()
        {
                _playerManager = GameObject.Find("PlayerHolster");
                Player[] playerArray = _playerManager.GetComponent<PlayerManager>().GetPlayers();
                for (int n = 0; n < playerArray.Length; n++)
                {
                        playerArray[n].SetNumber(n + 1);
                        playerArray[n].PlaceOnBoard();
                }
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
