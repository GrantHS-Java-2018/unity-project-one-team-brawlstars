using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using PlayerSetupScripts;
using TileScripts;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using Vector2 = System.Numerics.Vector2;
using Vector3 = UnityEngine.Vector3;

public class Player : MonoBehaviour
{
    private static Tile[] _tileArray;

    private int _playerNumber;

    [SerializeField] private int money;

    [SerializeField] private bool inJail;

    private int _railroadsOwned;

    private int _utilitiesOwned;
    
    private Vector3 _currentWaypoint;
        
    [SerializeField] private int boardLocation;
    
    private Sprite _tokenSprite;

    [FormerlySerializedAs("_playerGameObject")] [SerializeField] private GameObject playerGameObject;

    public void SetNumber(int playerIndex)
    {
        _playerNumber = playerIndex;
    }
    
    public void SetPlayerToken(Sprite token)
    {
        _tokenSprite = token;
    }
    
    public static void SetUpPlayers()
    {
        _tileArray = TileManager.GetAllTiles();
        
        Player[] playerArray = PlayerManager.GetPlayers();
        for (int n = 0; n < playerArray.Length; n++)
        {
            playerArray[n].SetNumber(n + 1);
            playerArray[n].PlaceOnBoard();
        }
    }
    
    public void PlaceOnBoard()
    {
        _currentWaypoint = _tileArray[0].GetTileWaypoint();
        
        playerGameObject = new GameObject();
        playerGameObject.name = "Player " + _playerNumber;

        playerGameObject.transform.position = _currentWaypoint;
        playerGameObject.transform.position.Scale(new Vector3(4f, 4f, 4f));
        
        playerGameObject.AddComponent<SpriteRenderer>();
        playerGameObject.GetComponent<SpriteRenderer>().sprite = _tokenSprite;
    }
    
    public void Move(int diceSum) //move a number of spaces equal to die sum
    {
        Vector3 nextWaypoint = _tileArray[boardLocation + 1].GetTileWaypoint();
        {
            while (_currentWaypoint != nextWaypoint)
            {
                _currentWaypoint = Vector3.MoveTowards(_currentWaypoint, nextWaypoint, 1f);
            }
        }
    }

    public void Send(int location) //send to a specific location
    {
        
    }
    
    public void GoToJail() //send to jail, RIGHT THROUGH BOARD, DO NOT PASS OTHER TILES
    {
        inJail = true;
    }
    
    public int GetRailroadsOwned()
    {
        return _railroadsOwned;
    }

    public int GetUtilitiesOwned()
    {
        return _utilitiesOwned;
    }
    
    public void Pay(int income)
    {
        
    }

    public void Charge(int expense)
    {
        
    }
}


