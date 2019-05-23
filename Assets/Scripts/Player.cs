using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using PlayerSetupScripts;
using TileScripts;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;
using UnityEngine.Serialization;
using UnityEngine.UI;
using Vector2 = System.Numerics.Vector2;
using Vector3 = UnityEngine.Vector3;

[System.Serializable]
public class Player
{
    private static Tile[] _tileArray;

    private int _playerNumber;

    [SerializeField] private int money;

    [SerializeField] private bool inJail;

    private int _railroadsOwned;

    private int _utilitiesOwned;
    
    [SerializeField] private Vector3 _currentPosition;
        
    [SerializeField] private int currentWaypoint;
    
    private Sprite _tokenSprite;

    [SerializeField] private GameObject playerGameObject;

    [SerializeField] private PlayerMovement playerMovementObject;

    public void SetNumber(int playerIndex)
    {
        _playerNumber = playerIndex;
    }
    
    public void SetPlayerToken(Sprite token)
    {
        _tokenSprite = token;
    }
    
    public void SetTileManager()
    {
        _tileArray = TileManager.GetAllTiles();
    }
    
    public void PlaceOnBoard()
    {
        _currentPosition = _tileArray[0].GetTileWaypoint();
        playerMovementObject = GameObject.Find("PlayerMovement").GetComponent<PlayerMovement>();
        
        playerGameObject = new GameObject();
        playerGameObject.name = "Player " + _playerNumber;

        playerGameObject.transform.position = _currentPosition;
        playerGameObject.transform.localScale = new Vector3(4f, 4f, 4f);
        
        playerGameObject.AddComponent<SpriteRenderer>();
        playerGameObject.GetComponent<SpriteRenderer>().sprite = _tokenSprite;
    }

    public void UpdatePosition()
    {
        playerGameObject.transform.position = _currentPosition;
    }

    public IEnumerator MoveCoroutine(int diceSum)
    {
        Vector3 nextWaypoint = _tileArray[currentWaypoint + diceSum].GetTileWaypoint();
        while (_currentPosition != nextWaypoint)
        {
            _currentPosition = Vector3.MoveTowards(_currentPosition, nextWaypoint, 1f);
            UpdatePosition();
            yield return null;
        }
        currentWaypoint = currentWaypoint + diceSum;
        playerMovementObject.MoveFinished();
    }

    public void SendCoroutine(int location) //send to a specific location
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


