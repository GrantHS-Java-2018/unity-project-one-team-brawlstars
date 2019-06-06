/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetUpProperty : MonoBehaviour
{
    // Start is called before the first frame update

    private Sprite[] Props;
    private SpriteRenderer rend;
    private Vector3 tempPosition1 = new Vector3( -768f * 512f, 450f, 0f);
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        Props = Resources.LoadAll<Sprite>("Sprites/Deeds/");
        rend.sprite = Props[22];  

    }

    private void loadProps()
    {
        rend.sprite = Props[3];
        Props[3].transform.position = tempPosition1;
       
    }
    
    

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
*/