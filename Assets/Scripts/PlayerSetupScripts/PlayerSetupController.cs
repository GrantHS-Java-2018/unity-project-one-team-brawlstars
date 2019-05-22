using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;
using UnityEngine.UI;

namespace PlayerSetupScripts
{
    public class PlayerSetupController : MonoBehaviour
    {
        [SerializeField] private GameObject tokenSelectionCanvas;

        public void SetUpPlayerManagerPointer()
        {
            tokenSelectionCanvas.SetActive(true);
            PlayerManager.SetUpPlayerManager(tokenSelectionCanvas);
        }
    }
}