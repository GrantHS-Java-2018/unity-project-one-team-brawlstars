using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

namespace Dice
{
    public class DieManagement : MonoBehaviour
    {
    
       public int num1;
       public int num2;
       public int roll;
       public bool pair;
       private bool _readyBool;
       private bool _jailRoll;
       
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

       public void StartJailRoll()
       {
           _jailRoll = true;
           GameLoop.EnableRollButton();
       }
       
       private void RollCalculation()
       {
           if (!_jailRoll)
           {
               roll = num1 + num2;
               IsPair();
               GameLoop.ReportDieRolls(roll, pair);
           }
           else
           {
               IsPair();
               if (pair)
               {
                   GameLoop.GetCurrentPlayer().GetOutOfJail();
               }
               else
               {
                   roll = 0;
               }
               GameLoop.ReportDieRolls(roll, false);
           }
           _jailRoll = false;
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