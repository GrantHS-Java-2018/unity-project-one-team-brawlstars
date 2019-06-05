using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dice
{
    public class DieManagement : MonoBehaviour
    {
    
       public int num1;
       public int num2;
       public int roll;
       public bool pair;
    
       public void RollCalculation()
       {
           roll = num1 + num2;
           IsPair();
           Debug.Log("we got there");
           GameLoop.ReportDieRolls(roll, pair);
       }
    
       private void IsPair()
       {
           if (num1 == num2)
           {
               pair = true;
           }
           else
           {
               pair = false;
           }
    
       }
    }
}