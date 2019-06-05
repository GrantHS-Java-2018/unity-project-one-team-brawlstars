using System.Collections;
using Dice;
using UnityEngine;

namespace Dice
{
    public class Die : MonoBehaviour
    {
        public int dieSideThrown;
        private Sprite[] diceSides;
        private SpriteRenderer rend;
        private bool coroutineAllowed = true;
        public GameObject dieManager;
        private DieManagement _dieManagerScript;
        public int dieNum;
        public int roll;

        public void Start()
        {
            _dieManagerScript = dieManager.GetComponent<DieManagement>();
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
                _dieManagerScript.num1 = dieSideThrown;
            }
            else
            {
                _dieManagerScript.num2 = dieSideThrown;
            }

            _dieManagerScript.RollCalculation();

            coroutineAllowed = true;
        }

    }
}