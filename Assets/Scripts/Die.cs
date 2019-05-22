using System.Collections;
using UnityEngine;

public class Die : MonoBehaviour
{
    public int dieSideThrown = 0;
    private Sprite[] _diceSides;
    private SpriteRenderer _rend;
    private bool _coroutineAllowed = true;



    private void Update()
    {
        
    }

    public void Start()
    {
        _rend = GetComponent<SpriteRenderer>();
        _diceSides = Resources.LoadAll<Sprite>("Sprites/DiceSides/");
        _rend.sprite = _diceSides[5];
    }

    public void ClickButton()
    {
        if (_coroutineAllowed)
            StartCoroutine(RollTheDice());
    }

    private IEnumerator RollTheDice()
    {
        _coroutineAllowed = false;
        int randomDiceSide = 0;
        for (int i = 0; i <= 20; i++)
        {
            randomDiceSide = Random.Range(0, 6);
            _rend.sprite = _diceSides[randomDiceSide];
            yield return new WaitForSeconds(0.05f);
        }
        
        dieSideThrown = randomDiceSide + 1;

        _coroutineAllowed = true;
        
    }

}
