﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private Sprite _tokenSprite;

    public void SetPlayerToken(Sprite token)
    {
        _tokenSprite = token;
    }
}