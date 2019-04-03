using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Resizer : MonoBehaviour
{
    private Vector3 currentScale = new Vector3(0.05f, 0.05f);
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            currentScale.x = currentScale.x + 0.01f;
            currentScale.y = currentScale.y + 0.01f;
            transform.localScale = currentScale;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            currentScale.x = currentScale.x - 0.01f;
            currentScale.y = currentScale.y - 0.01f;
            transform.localScale = currentScale;
        }
    }
}
