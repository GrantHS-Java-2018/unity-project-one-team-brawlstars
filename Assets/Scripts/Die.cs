using System.Collections;
using UnityEngine;

public class Dice : MonoBehaviour
{
    public int diceOneSideThrown = 0;
    private Sprite[] diceSides;
    private SpriteRenderer rend;
    private bool coroutineAllowed = true;


    private void Update()
    {
        
    }

    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        diceSides = Resources.LoadAll<Sprite>("DiceSides/");
        rend.sprite = diceSides[5];
    }

    private void OnMouseDown()
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
        
        diceOneSideThrown = randomDiceSide + 1;

        coroutineAllowed = true;
        
    }

}
