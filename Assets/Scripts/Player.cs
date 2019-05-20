using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using TileScripts;
using UnityEngine;
using UnityEngine.UI;
using Vector2 = System.Numerics.Vector2;
using Vector3 = UnityEngine.Vector3;

public class Player : MonoBehaviour
{
    private static TileManager _tileManager;

    private int _playerNumber;

    [SerializeField] private int money;

    [SerializeField] private bool inJail;

    private int _railroadsOwned;

    private int _utilitiesOwned;
    
    private Vector3 _currentWaypoint;
        
    [SerializeField] private int boardLocation;
    
    private Sprite _tokenSprite;

    private GameObject _playerGameObject;

    public void SetNumber(int index)
    {
        _playerNumber = index;
    }
    
    public void PlaceOnBoard()
    {
        _currentWaypoint = _tileManager.gameTiles[0].GetTileWaypoint();
        
        _playerGameObject = new GameObject();
        _playerGameObject.name = "Player " + _playerNumber;

        _playerGameObject.transform.position = _currentWaypoint;
        _playerGameObject.transform.position.Scale(new Vector3(4f, 4f, 4f));
        
        _playerGameObject.AddComponent<SpriteRenderer>();
        _playerGameObject.GetComponent<SpriteRenderer>().sprite = _tokenSprite;
    }
    
    public int GetRailroadsOwned()
    {
        return _railroadsOwned;
    }

    public int GetUtilitiesOwned()
    {
        return _utilitiesOwned;
    }

    public static void PointPlayersToTiles(TileManager tileManager) //Stores tileManager with its tile array for future reference
    {
        _tileManager = tileManager;
    }
    
    public void SetPlayerToken(Sprite token)
    {
        _tokenSprite = token;
    }

    public void Move(int diceSum) //move a number of spaces equal to die sum
    {
        Vector3 nextWaypoint = _tileManager.gameTiles[boardLocation + 1].GetTileWaypoint();
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
    
    public void Pay(int income)
    {
        
    }

    public void Charge(int expense)
    {
        
    }
}


