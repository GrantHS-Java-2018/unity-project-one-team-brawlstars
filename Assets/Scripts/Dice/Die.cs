using System.Collections;
using UnityEngine;

public class Die : MonoBehaviour
{
    public int dieSideThrown = 0;
    private Sprite[] diceSides;
    private SpriteRenderer rend;
    private bool coroutineAllowed = true;
    public GameObject dieManager;
    public int dieNum;
    public int roll;
  



    private void Update()
    {
      
    }

    public void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        diceSides = Resources.LoadAll<Sprite>("Sprites/DiceSides/");
        rend.sprite = diceSides[5];
    }

    public void ClickButton()
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
        if (dieNum == 1)
        {
            dieManager.GetComponent<DieManagement>().num1 = dieSideThrown;
        }
        else
        {
            dieManager.GetComponent<DieManagement>().num2 = dieSideThrown;
        }

        dieManager.GetComponent<DieManagement>().RollCalculation();

        coroutineAllowed = true;
      
      
      
    }

}
