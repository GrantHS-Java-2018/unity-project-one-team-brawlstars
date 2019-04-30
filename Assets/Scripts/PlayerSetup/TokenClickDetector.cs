using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;
using UnityEngine.UI;

namespace PlayerSetup
{
    public class TokenClickDetector : MonoBehaviour
    {   
        private int _playerIndex = 0;

        [SerializeField] private Button buttonOfImport;

        [SerializeField] private Player[] playersArray;

        [SerializeField] private Canvas initialDropdownCanvas;
        
        void Start()
        {
            gameObject.SetActive(false);
        }

        void Update()
        {
            if (!initialDropdownCanvas.isActiveAndEnabled)
            {
                playersArray = buttonOfImport.GetComponent<PlayerSetupManager>().GetPlayers();
            }
            
        }
        
        private void OnMouseOver()
        {
            if (Input.GetMouseButtonDown(0))
            {
                gameObject.SetActive(false);
                //playersArray[_playerIndex].SetPlayerToken(gameObject.GetComponent<Sprite>());
            }
        }
    }
}