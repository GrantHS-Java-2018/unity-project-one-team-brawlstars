using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CardScripts;
using Dice;
using PlayerSetupScripts;
using TileScripts;
using TileScripts.PurchasableTiles;
using TileScripts.SpecialTiles;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using Image = UnityEngine.Experimental.UIElements.Image;

public class PopupManager : MonoBehaviour
{
    private static GameObject _popupBackground;

    private static GameObject[] _choiceButtons;

    private static int _tileToBuy;

    private static DieManagement _dieManagement;

    public static void SetUpPopupManager()
    {
        _popupBackground = GameObject.Find("PopupBackground");
        _choiceButtons = new GameObject[3];
        for (int n = 1; n < 4; n++)
        {
            _choiceButtons[n - 1] = GameObject.Find("Option" + n);
        }
        _popupBackground.SetActive(false);
        _dieManagement = GameObject.Find("DieManagement").GetComponent<DieManagement>();
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
        _popupBackground.GetComponentInChildren<SpriteRenderer>().transform.localScale = new Vector3(180f, 180f, 180f);
        _popupBackground.SetActive(false);
        GameLoop.ActivateGameButtons();
    }

    private static void BuyProperty()
    {
        PropertyTile property = (PropertyTile) TileManager.GetTile(_tileToBuy);
        property.Buy();
    }

    private static void ChargeJailFee()
    {
        GameLoop.GetCurrentPlayer().Charge(50);
    }

    private static void GetOutOfJail()
    {
        GameLoop.GetCurrentPlayer().GetOutOfJail();
    }

    private static void UseGetOutOfJailCard()
    {
        GameLoop.GetCurrentPlayer().ChangeGetOutOfJailCard(false);
    }

    private static void DoCardAction()
    {
        CardDeckTile.GetCurrentCard().DoCardAction();
    }

    private static void StartJailRoll()
    {
        _dieManagement.StartJailRoll();
    }
    //choiceType key: 0 is just an okay, 1 is unowned property, 2 is get out of jail, 3 is card to accept
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
                _choiceButtons[0].GetComponent<Button>().onClick.AddListener(ResetPopup);
                
                _choiceButtons[1].SetActive(false);
                _choiceButtons[2].SetActive(false);
                break;
            case 1:
                _tileToBuy = currentTile;
                _choiceButtons[0].GetComponentInChildren<Text>().text = "Purchase";
                _choiceButtons[0].GetComponent<Button>().onClick.AddListener(BuyProperty);
                _choiceButtons[0].GetComponent<Button>().onClick.AddListener(ResetPopup);
                
                _choiceButtons[1].GetComponentInChildren<Text>().text = "Ignore";
                _choiceButtons[1].GetComponent<Button>().onClick.AddListener(ResetPopup);
                
                _choiceButtons[2].SetActive(false);
                break;
            case 2:
                _choiceButtons[0].GetComponentInChildren<Text>().text = "Try for Pair";
                _choiceButtons[0].GetComponent<Button>().onClick.AddListener(StartJailRoll);
                _choiceButtons[0].GetComponent<Button>().onClick.AddListener(ResetPopup);
              
                
                _choiceButtons[1].GetComponentInChildren<Text>().text = "Pay Fine of $50";
                _choiceButtons[1].GetComponent<Button>().onClick.AddListener(ChargeJailFee);
                _choiceButtons[1].GetComponent<Button>().onClick.AddListener(GetOutOfJail);
                _choiceButtons[1].GetComponent<Button>().onClick.AddListener(ResetPopup);
                
                if (GameLoop.GetCurrentPlayer().CheckForGetOutOfJailCard())
                {
                    _choiceButtons[2].GetComponentInChildren<Text>().text = "Use Get Out of Jail Free Card";
                    _choiceButtons[2].GetComponent<Button>().onClick.AddListener(UseGetOutOfJailCard);
                    _choiceButtons[2].GetComponent<Button>().onClick.AddListener(GetOutOfJail);
                    _choiceButtons[2].GetComponent<Button>().onClick.AddListener(ResetPopup);
                }
                else
                {
                    _choiceButtons[2].SetActive(false);
                }
                break;
            case 3:
                _popupBackground.GetComponentInChildren<SpriteRenderer>().transform.localScale = new Vector3(43.4f, 43.4f, 43.4f);
                _choiceButtons[0].GetComponentInChildren<Text>().text = "Okay";
                _choiceButtons[0].GetComponent<Button>().onClick.AddListener(DoCardAction);
                _choiceButtons[0].GetComponent<Button>().onClick.AddListener(ResetPopup);

                _choiceButtons[1].SetActive(false);
                _choiceButtons[2].SetActive(false);
                break;
        }

    }
}
