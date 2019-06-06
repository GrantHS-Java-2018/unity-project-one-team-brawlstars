﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using PlayerSetupScripts;
using TileScripts;
using TileScripts.PurchasableTiles;
using TMPro;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using Image = UnityEngine.Experimental.UIElements.Image;

public class PopupManager : MonoBehaviour
{
    private static GameObject _popupBackground;

    private static GameObject[] _choiceButtons;

    private static int _tileToBuy;

    public static void SetUpPopupManager()
    {
        _popupBackground = GameObject.Find("PopupBackground");
        _choiceButtons = new GameObject[3];
        for (int n = 1; n < 4; n++)
        {
            _choiceButtons[n - 1] = GameObject.Find("Option" + n);
        }
        _popupBackground.SetActive(false);
    }

    private static void ActivateChoiceButtons()
    {
        for (int n = 0; n < 3; n++)
        {
            _choiceButtons[n].SetActive(true);
        }
    }

    private static void ResetPopup()
    {
        for (int n = 0; n < 3; n++)
        {
            _choiceButtons[n].GetComponent<Button>().onClick.RemoveAllListeners();
        }
        _popupBackground.SetActive(false);
        GameLoop.ActivateGameButtons();
    }

    private static void BuyProperty()
    {
        PropertyTile property = (PropertyTile) TileManager.GetTile(_tileToBuy);
        property.Buy();
    }

    //choiceType key: 0 is just an okay, 1 is unowned property, 2 is get out of jail
    public static void MakeNewPopUp(int choiceType, int currentTile, Sprite choiceSprite)
    {
        GameLoop.DeactivateGameButtons();
        _popupBackground.SetActive(true);
        _popupBackground.GetComponentInChildren<SpriteRenderer>().sprite = choiceSprite;
        ActivateChoiceButtons();
        
        switch (choiceType)
        {
            case 0:
                _choiceButtons[0].GetComponentInChildren<Text>().text = "Okay";
                _choiceButtons[1].SetActive(false);
                _choiceButtons[2].SetActive(false);
                
                _choiceButtons[0].GetComponent<Button>().onClick.AddListener(ResetPopup);
                break;
            case 1:
                _tileToBuy = currentTile;
                _choiceButtons[0].GetComponentInChildren<Text>().text = "Purchase";
                _choiceButtons[1].GetComponentInChildren<Text>().text = "Ignore";
                _choiceButtons[2].SetActive(false);
                
                _choiceButtons[0].GetComponent<Button>().onClick.AddListener(BuyProperty);
                _choiceButtons[0].GetComponent<Button>().onClick.AddListener(ResetPopup);
                _choiceButtons[1].GetComponent<Button>().onClick.AddListener(ResetPopup);
                break;
            //case 2 will go here eventually, with jail selection
        }
        
    }
}