using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngineInternal;

namespace PlayerSetupScripts
{
    public class PlayerSetupManager : MonoBehaviour
    {
        [SerializeField] private Dropdown playerCountDropdown;

        [SerializeField] private Player[] players;

        [SerializeField] private int playerIndex;

        [SerializeField] private GameObject tokenSelectionCanvas;

        private void Awake()
        {
            DontDestroyOnLoad(this);
        }

        public void InitializePlayers()
        {
            players = new Player[playerCountDropdown.value + 2];
            for (int n = 0; n < playerCountDropdown.value + 2; n++)
            {
                players[n] = gameObject.AddComponent<Player>();
            }
        }
        
        public void AssignToken(Sprite assignedToken)
        {
            players[playerIndex].SetPlayerToken(assignedToken);
            playerIndex += 1;
            if (playerIndex < playerCountDropdown.value + 2)
            {
                tokenSelectionCanvas.GetComponentInChildren<Text>().text = "Player " + (playerIndex + 1) + ", pick a token";
            }
            else
            {
                SceneManager.LoadScene("BoardScene");
            }
            
        }

        public Player[] GetPlayersFromStart()
        {
            return players;
        }

        
    }
}