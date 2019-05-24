using UnityEngine;

namespace Scripts.CardScripts
{
    public class CommunityChest
    {
        public class Advance : Card
        {
            private readonly int tileToAdvance;

            public Advance(int _tileToAdvance)
            {
                _tileToAdvance = tileToAdvance;
                cat = 0;
            }
            public override int Activate(int[] )

        }
    }
}