using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;
using UnityEngine.UI;

namespace PlayerSetupScripts
{
    public class TokenClickDetector : MonoBehaviour
    {   
        [SerializeField] private GameObject playerArrayHolster; //Game object that permanently holds player manager
        
        void Start()
        {
            gameObject.SetActive(false);
        }
        
        private void OnMouseOver()
        {
            if (Input.GetMouseButtonDown(0))
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = gameObject.GetComponent<SpriteRenderer>().sprite;
                gameObject.SetActive(false);
                PlayerManager.AssignToken(gameObject.GetComponent<SpriteRenderer>().sprite);
            }
        }
    }
}