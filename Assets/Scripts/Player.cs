using System.Collections;
using System.Collections.Generic;
using TileScripts;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private static TileManager _tileManager;
    
    [SerializeField] private Sprite _tokenSprite;

    [SerializeField] private int boardLocation;

    [SerializeField] private int money;

    [SerializeField] private bool inJail;

    private int _railroadsOwned;

    private int _utilitiesOwned;
    
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
        Debug.Log(_tileManager.gameTiles[39].TileName);
    }
    
    public void SetPlayerToken(Sprite token)
    {
        _tokenSprite = token;
    }

    public void Move(int diceSum) //move a number of spaces equal to die sum
    {
        
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


