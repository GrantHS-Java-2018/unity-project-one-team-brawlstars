using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieManagement : MonoBehaviour
{

   public int num1;
   public int num2;
   public int roll;
   public bool pair;
  
  

   // Start is called before the first frame update
   void Start()

   {
       RollCalculation();
      
   }

   // Update is called once per frame
   void Update()
   {


   }

   public void RollCalculation()
   {
       roll = num1 + num2;
       IsPair();

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
