using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;
using UnityEngine.UI;

namespace PlayerSetupScripts
{
    public class PlayerSetupController : MonoBehaviour
    {
        void Start()
        {
            PlayerManager.SetUpPlayerManager();
        }
    }
}