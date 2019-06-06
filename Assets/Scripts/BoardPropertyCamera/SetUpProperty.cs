using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetUpProperty : MonoBehaviour
{

    void Start()
    {
        Sprite[] propSprites = Resources.LoadAll<Sprite>("Sprites/Deeds");
        
        for (int i = 0; i < 22; i++)
        {         
            //Create the cardInstance
            GameObject cardInstance = new GameObject("Deed" + i);
            cardInstance.transform.parent = this.transform;

            SpriteRenderer spriteRenderer = cardInstance.AddComponent<SpriteRenderer>();
            spriteRenderer.sprite = propSprites[i];
            
            
            
            float myScale = 4f;
            spriteRenderer.transform.localScale = new Vector3(100f, 100f, 100f);
            cardInstance.transform.position = new Vector3( 900f, -1700 - 100 * i, 0f);
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
