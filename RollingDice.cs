using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingDice : MonoBehaviour
{
    [SerializeField] int numberGot;
    [SerializeField] GameObject rollingDiceAnim;
    [SerializeField] SpriteRenderer numberedSpHolder;
    [SerializeField] Sprite[] numberedSprites;
    
    bool canDiceRoll = true; 

    Coroutine generateRandomNumOnDice_Coroutine; 

    void OnMouseDown()
    {
        generateRandomNumOnDice_Coroutine = StartCoroutine(GenerateRandomNumberOnDice_Enum());
    }

    IEnumerator GenerateRandomNumberOnDice_Enum()
    {
        yield return new WaitForEndOfFrame();
        if(canDiceRoll)
        {
            canDiceRoll = false;
            numberedSpHolder.gameObject.SetActive(false);
            rollingDiceAnim.SetActive(true);
            yield return new WaitForSeconds(1f);
            numberGot = Random.Range(0,6);
            numberedSpHolder.sprite = numberedSprites[numberGot];
            numberGot += 1;

            GameManager.gm.numOfStepsToMove = numberGot;
            GameManager.gm.rolledDice = this;

            numberedSpHolder.gameObject.SetActive(true);
            rollingDiceAnim.SetActive(false);
            yield return new WaitForEndOfFrame();
            canDiceRoll=true;
            if(generateRandomNumOnDice_Coroutine != null)
            {
                StopCoroutine(generateRandomNumOnDice_Coroutine);
            }
        }
    }

}
