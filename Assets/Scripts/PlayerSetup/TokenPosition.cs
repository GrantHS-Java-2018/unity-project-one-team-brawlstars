using UnityEngine;

namespace PlayerSetup
{
    public class TokenPosition : MonoBehaviour
    {
        private Vector3[] _tokenPositions = new Vector3[8];
        
        // Start is called before the first frame update
        void Start()
        {
            Vector3 oldPosition = new Vector3(-25.95f, 10f, 0);
            for (int n = 0; n < 4; n++)
            {
                Vector3 tempPosition = new Vector3((float) (oldPosition.x + n * 8.65), 0f, 0f);
                _tokenPositions[n] = tempPosition;
                gameObject.transform.GetChild(n).position = _tokenPositions[n];
            }
        }
    }
}
