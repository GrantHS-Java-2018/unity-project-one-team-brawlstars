using System.Collections;
using UnityEngine;

public class Die : MonoBehaviour
{
    public int dieSideThrown = 0;
    private Sprite[] diceSides;
    private SpriteRenderer rend;
    private bool coroutineAllowed = true;



    private void Update()
    {
        
    }

    public void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        diceSides = Resources.LoadAll<Sprite>("DiceSides/");
        rend.sprite = diceSides[5];
    }

    public void RollTheDiceStart()
    {
        if (coroutineAllowed)
            StartCoroutine(RollTheDice());
    }

    private IEnumerator RollTheDice()
    {
        coroutineAllowed = false;
        int randomDiceSide = 0;
        for (int i = 0; i <= 20; i++)
        {
            randomDiceSide = Random.Range(0, 6);
            rend.sprite = diceSides[randomDiceSide];
            yield return new WaitForSeconds(0.05f);
        }
        
        dieSideThrown = randomDiceSide + 1;

        coroutineAllowed = true;
        
    }

}
