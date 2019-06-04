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
  

    public void Start()  //Renders sprite and puts them in an array
    {
        rend = GetComponent<SpriteRenderer>();
        diceSides = Resources.LoadAll<Sprite>("Sprites/DiceSides/");
        rend.sprite = diceSides[5];        
    }

    public void ClickButton() //When the button is clicked
    {
        if (coroutineAllowed)   //always true at start
            StartCoroutine(RollTheDice()); //Begins roll the dice method
    }

    private IEnumerator RollTheDice()
    {
        coroutineAllowed = false; //makes the coroutine false so you can't countinually role
        int randomDiceSide = 0;
        for (int i = 0; i <= 20; i++) //for loop cycles between random die side sprites
        {
            randomDiceSide = Random.Range(0, 6); //random sides
            rend.sprite = diceSides[randomDiceSide]; //render the random sprite
            yield return new WaitForSeconds(0.05f); //wait between sprite renders
        }
      
      
        dieSideThrown = randomDiceSide + 1; //assigns the end side to the corresponding value
        if (dieNum == 1) 
        {
            dieManager.GetComponent<DieManagement>().num1 = dieSideThrown; //gives die one a value
        }
        else
        {
            dieManager.GetComponent<DieManagement>().num2 = dieSideThrown; //give die two a value
        }

        dieManager.GetComponent<DieManagement>().RollCalculation(); //Gives roll a sum (in diemanagment class)

        coroutineAllowed = true;//allows dice to be rolled again
      
      
      
    }

}
