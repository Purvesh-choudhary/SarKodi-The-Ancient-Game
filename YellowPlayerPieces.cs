using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowPlayerPieces : PlayerPiece
{
    RollingDice yellowHomeRollingDice;

    private void Start() {
        yellowHomeRollingDice = GetComponentInParent<YellowHome>().rollingDice;
    }

    private void OnMouseDown() 
    {   
        if(GameManager.gm.rolledDice != null)
        {
            if(!isReady)
            {
                if(GameManager.gm.rolledDice == yellowHomeRollingDice && GameManager.gm.numOfStepsToMove == 6)
                {
                    MakePlayerReadyToMove();
                    GameManager.gm.numOfStepsToMove = 0;
                    return;
                }
            }
            if(GameManager.gm.rolledDice == yellowHomeRollingDice && isReady)
            {
                canMove = true;
            }    
        }
        MoveSteps();
    }   

}
