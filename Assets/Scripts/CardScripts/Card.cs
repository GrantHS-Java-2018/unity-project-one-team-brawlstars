﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.CardScripts
{
    public abstract class Card : MonoBehaviour
    {
        private int num;
        private int type;
        public int[] CommunityChest = new int[16];
        public int[] Chance = new int[16];
      

        public Card(int num, int type)
        {
            this.num = num;
            this.type = type;
        }

   



    }

}


