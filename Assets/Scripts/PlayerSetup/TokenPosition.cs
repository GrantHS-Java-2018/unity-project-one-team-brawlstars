using UnityEngine;

namespace PlayerSetup
{
    public class TokenPosition : MonoBehaviour
    {
        private Vector3[] _tokenPositions = new Vector3[8];

        public GameObject[] tokens = new GameObject[8];
        
        // Start is called before the first frame update
        void Start()
        {
            for (int n = 0; n < 4; n++)
            {
                Vector3 tempPosition = new Vector3( -12f + n * 8f, 5f, 0f);
                _tokenPositions[n] = tempPosition;
            }

            for (int n = 4; n < 8; n++)
            {
                Vector3 tempPosition = new Vector3( -12f + (n - 4) * 8f, -1f, 0f);
                _tokenPositions[n] = tempPosition;
            }

            for (int n = 0; n < 8; n++)
            {
                tokens[n].transform.position = _tokenPositions[n];
            }
        }
    }
}
