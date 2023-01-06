﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenPlayerPieces : PlayerPiece
{
    RollingDice greenHomeRollingDice;

    private void Start() {
        greenHomeRollingDice = GetComponentInParent<GreenHome>().rollingDice;
    }

    
    private void OnMouseDown() 
    {   
        if(GameManager.gm.rolledDice != null)
        {
            if(!isReady)
            {
                if(GameManager.gm.rolledDice == greenHomeRollingDice && GameManager.gm.numOfStepsToMove == 6)
                {
                    MakePlayerReadyToMove();
                    GameManager.gm.numOfStepsToMove = 0;
                    return;
                }
            }
            if(GameManager.gm.rolledDice == greenHomeRollingDice && isReady)
            {
                canMove = true;
            }    
        }
        MoveSteps();
    }
    
}
