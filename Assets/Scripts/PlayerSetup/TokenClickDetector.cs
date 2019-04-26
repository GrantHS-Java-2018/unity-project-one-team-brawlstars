using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerSetup
{
    public class TokenClickDetector : MonoBehaviour
    {   
        void Start()
        {
            gameObject.SetActive(false);
        }
        
        private void OnMouseOver()
        {
            if (Input.GetMouseButtonDown(0))
            {
                gameObject.SetActive(false);
            }
        }
    }
}