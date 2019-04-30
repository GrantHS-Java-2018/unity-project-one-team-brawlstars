using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;
using UnityEngine.UI;

namespace PlayerSetup
{
    public class TokenClickDetector : MonoBehaviour
    {   
        [SerializeField] private Button buttonOfImport;

        [SerializeField] private Canvas initialDropdownCanvas;

        [SerializeField] private GameObject playerArrayHolster;
        
        void Start()
        {
            gameObject.SetActive(false);
        }
        
        private void OnMouseOver()
        {
            if (Input.GetMouseButtonDown(0))
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = gameObject.GetComponent<Sprite>();
                gameObject.SetActive(false);
                playerArrayHolster.GetComponent<PlayerSetupManager>().AssignToken(gameObject.GetComponent<SpriteRenderer>().sprite);
            }
        }
    }
}