using UnityEngine;
using System.Collections;

public class SetUpCamera : MonoBehaviour {
    public Camera MainCamera;
    public Camera PropertyCamera;

    private void Start()
    {
        MainCamera.enabled = true;
        PropertyCamera.enabled = false;
    }

    public void ShowBoard() {
        MainCamera.enabled = true;
        PropertyCamera.enabled = false;
    }
    
    public void ShowProperty() {
        MainCamera.enabled = false;
        PropertyCamera.enabled = true;
    }
}