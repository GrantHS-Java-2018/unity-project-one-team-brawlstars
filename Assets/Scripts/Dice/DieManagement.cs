using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Dice
{
    public class DieManagement : MonoBehaviour
    {
    
       public int num1;
       public int num2;
       public int roll;
       public bool pair;
       private bool _readyBool;
    
       public void DieReady()
       {
           if (!_readyBool)
           {
               _readyBool = true;
           }
           else
           {
               RollCalculation();
               _readyBool = false;
           }
       }
       
       private void RollCalculation()
       {
           roll = num1 + num2;
           IsPair();
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