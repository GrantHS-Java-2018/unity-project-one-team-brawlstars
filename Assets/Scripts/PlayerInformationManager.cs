using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using PlayerSetupScripts;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInformationManager : MonoBehaviour
{
    private static PlayerInformationManager _playerInformationManager;
    [SerializeField] private GameObject[] _playerInfoGameObjects;
    [SerializeField] private Text[] _moneyTexts;
    [SerializeField] private Text[] _inJailTexts;
    [SerializeField] private Text[] _jailCardTexts;
    private int _numberOfPlayers;

    public static void SetUpPlayerInformationManager(int incomingNumberOfPlayers)
    {
        _playerInformationManager = GameObject.Find("PlayerInformationCanvas").GetComponent<PlayerInformationManager>();
        _playerInformationManager._numberOfPlayers = incomingNumberOfPlayers;
        _playerInformationManager._playerInfoGameObjects = new GameObject[8];
        _playerInformationManager._moneyTexts = new Text[incomingNumberOfPlayers];
        _playerInformationManager._inJailTexts = new Text[incomingNumberOfPlayers];
        _playerInformationManager._jailCardTexts = new Text[incomingNumberOfPlayers];

        for (int n = 0; n < 8; n++)
        {
            Debug.Log(n);
            _playerInformationManager._playerInfoGameObjects[n] = GameObject.Find("Player" + (n+1) + "Info");
        }

        for (int n = incomingNumberOfPlayers; n < 8; n++)
        {
            _playerInformationManager._playerInfoGameObjects[n].SetActive(false);
        }
        
        for (int n = 0; n < incomingNumberOfPlayers; n++)
        {
            _playerInformationManager._moneyTexts[n] =
                _playerInformationManager._playerInfoGameObjects[n].transform.Find("Money").GetComponent<Text>();
            
            _playerInformationManager._inJailTexts[n] =
                _playerInformationManager._playerInfoGameObjects[n].transform.Find("InJail").GetComponent<Text>();
            
            _playerInformationManager._jailCardTexts[n] =
                _playerInformationManager._playerInfoGameObjects[n].transform.Find("GetOutOfJailCard").GetComponent<Text>();
        }
    }

    public static void UpdatePlayerInfo()
    {
        int numberOfPlayers = _playerInformationManager._numberOfPlayers;
        
        for (int n = 0; n < numberOfPlayers; n++)
        {   
            var playerMoney = PlayerManager.GetPlayers()[n].GetMoney();
            bool playerInJail = PlayerManager.GetPlayers()[n].CheckIfJailed(false);
            bool playerJailCard = PlayerManager.GetPlayers()[n].CheckForGetOutOfJailCard();

            _playerInformationManager._moneyTexts[n].text = "Money: " + playerMoney;
            _playerInformationManager._inJailTexts[n].text = "In Jail: " + playerInJail;
            _playerInformationManager._jailCardTexts[n].text = "Out of Jail Card: " + playerJailCard;
        }
        
    }
}
