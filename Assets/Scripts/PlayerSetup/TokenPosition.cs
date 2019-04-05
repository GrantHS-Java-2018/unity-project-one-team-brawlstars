using UnityEngine;

namespace PlayerSetup
{
    public class TokenPosition : MonoBehaviour
    {
        private Vector3[] _tokenPositions = new Vector3[8];
        
        // Start is called before the first frame update
        void Start()
        {
            Vector3 oldPosition = new Vector3(-18f, 18f, 1);
            for (int n = 0; n < 8; n++)
            {
                Vector3 tempPosition;
                tempPosition = new Vector3(oldPosition.x + n * 3, 18f, 1f);
                _tokenPositions[n] = tempPosition;
                gameObject.transform.GetChild(n).transform.position = _tokenPositions[n];
            }
        }
    }
}
