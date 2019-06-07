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

    [SerializeField] private int _playerNumber;

    [SerializeField] private int money;

    [SerializeField] private bool inJail;

    private int _railroadsOwned;

    private int _utilitiesOwned;
    
    [SerializeField] private Vector3 _currentPosition;
        
    [SerializeField] private int currentWaypoint;
    
    private Sprite _tokenSprite;

    [SerializeField] private GameObject playerGameObject;

    private bool _getOutOfJailCard;

    public void SetNumber(int playerIndex)
    {
        _playerNumber = playerIndex + 1;
    }

    public int GetNumber()
    {
        return _playerNumber;
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
        _currentPosition = _tileArray[0].GetTilePosition();
        
        playerGameObject = new GameObject();
        playerGameObject.name = "Player " + _playerNumber;

        playerGameObject.transform.position = _currentPosition;
        playerGameObject.transform.localScale = new Vector3(8f, 8f, 8f);
        
        playerGameObject.AddComponent<SpriteRenderer>();
        playerGameObject.GetComponent<SpriteRenderer>().sprite = _tokenSprite;
    }

    public void UpdatePosition()
    {
        playerGameObject.transform.position = _currentPosition;
    }

    public int GetNextMovementWaypoint(int movementAmount)
    {
        int waypoint;
        if (currentWaypoint + movementAmount > 39)
        {
            waypoint = currentWaypoint + movementAmount - 40;
        }
        else
        {
            waypoint = currentWaypoint + movementAmount;
        }

        return waypoint;
    }

    public IEnumerator MoveCoroutine(int diceSum)
    {
        Vector3 finalPosition = TileManager.GetTile(GetNextMovementWaypoint(diceSum)).GetTilePosition();
        
        while (_currentPosition != finalPosition)
        {   
            Vector3 nextPosition = TileManager.GetTile(GetNextMovementWaypoint(1)).GetTilePosition();
            
            while (_currentPosition != nextPosition)
            {
                _currentPosition = Vector3.MoveTowards(_currentPosition, nextPosition, 10f);
                UpdatePosition();
                yield return null;
            }
            currentWaypoint = GetNextMovementWaypoint(1);
            if (currentWaypoint == 0)
            {
                Pay(200);
            }
        }
        TileManager.GetTile(currentWaypoint).DoTileAction();
    }

    public IEnumerator SendCoroutine(int location) //send to a specific location
    {
        Vector3 finalPosition = TileManager.GetTile(location).GetTilePosition();
        
        while (_currentPosition != finalPosition)
        {   
            Vector3 nextPosition = TileManager.GetTile(GetNextMovementWaypoint(1)).GetTilePosition();
            
            while (_currentPosition != nextPosition)
            {
                _currentPosition = Vector3.MoveTowards(_currentPosition, nextPosition, 30f);
                UpdatePosition();
                yield return null;
            }
            currentWaypoint = GetNextMovementWaypoint(1);
            if (currentWaypoint == 0)
            {
                Pay(200);
            }
        }
        TileManager.GetTile(currentWaypoint).DoTileAction();
    }
    
    public IEnumerator GoToJailCoroutine() //send to jail, RIGHT THROUGH BOARD, DO NOT PASS OTHER TILES
    {
        Vector3 finalPosition = TileManager.GetTile(10).GetTilePosition();
        while (_currentPosition != finalPosition)
        {
            _currentPosition = Vector3.MoveTowards(_currentPosition, finalPosition, 20f);
            {
                UpdatePosition();
                yield return null;
            }
        }
        currentWaypoint = 10;
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
    
    public bool CheckIfJailed()
    {
        return inJail;
    }
    
    public void GetOutOfJail()
    {
        inJail = false;
    }

    public bool CheckForGetOutOfJailCard()
    {
        return _getOutOfJailCard;
    }

    public void ChangeGetOutOfJailCard(bool inOrOut)
    {
        _getOutOfJailCard = inOrOut;
    }

    
    
    
    public void Pay(int income)
    {
        money = money + income;
    }

    public void Charge(int expense)
    {
        money = money - expense;
    }
}


