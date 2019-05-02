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


