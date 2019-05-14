using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
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
    
    public void SetPlayerToken(Sprite token)
    {
        _tokenSprite = token;
    }

    public void Move(int dieSum)
    {
        
    }
    
    public void Pay(int income)
    {
        
    }

    public void Charge(int expense)
    {
        
    }
}


