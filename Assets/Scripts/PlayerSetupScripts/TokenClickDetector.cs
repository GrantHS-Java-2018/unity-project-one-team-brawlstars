using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;
using UnityEngine.UI;

namespace PlayerSetupScripts
{
    public class TokenClickDetector : MonoBehaviour
    {   
        [SerializeField] private GameObject playerArrayHolster;
        
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
                
                playerArrayHolster.GetComponent<PlayerManager>().AssignToken(gameObject.GetComponent<SpriteRenderer>().sprite);
                
                //Next step is to make sure that above line works with playerSetupManager script, and to make it so we actually cast sprite to the player instance
                //It doesn't look like the player script instances are actually having their token sprites changed in Unity editor
                //Perhaps there is a different way of getting gameObject component scripts, or we can't assign sprites to objects in this way
            }
        }
    }
}