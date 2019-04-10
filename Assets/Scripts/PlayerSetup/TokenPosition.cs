using UnityEngine;

namespace PlayerSetup
{
    public class TokenPosition : MonoBehaviour
    {
        private Vector3[] _tokenPositions = new Vector3[8];

        public GameObject tokens;
        
        // Start is called before the first frame update
        void Start()
        {
            for (int n = 0; n < 4; n++)
            {
                Vector3 tempPosition = new Vector3( -25.95f + n * 8.65f, 10f, 0f);
                _tokenPositions[n] = tempPosition;
                tokens.transform.GetChild(n).position = _tokenPositions[n];
                tokens.transform.GetChild(3).position = new Vector3(0f, 0f, 0f);
            }

            for (int n = 4; n < 8; n++)
            {
                Vector3 tempPosition = new Vector3( -25.95f + (n - 4) * 8.65f, -2f, 0f);
                _tokenPositions[n] = tempPosition;
                tokens.transform.GetChild(n).position = _tokenPositions[n];
            }
        }
    }
}
