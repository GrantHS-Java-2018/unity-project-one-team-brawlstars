using UnityEngine;

namespace PlayerSetupScripts
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
                Vector3 tempPosition = new Vector3( -768f + n * 512f, 450f, 0f);
                _tokenPositions[n] = tempPosition;
            }

            for (int n = 4; n < 8; n++)
            {
                Vector3 tempPosition = new Vector3( -768f + (n - 4) * 512f, -100f, 0f);
                _tokenPositions[n] = tempPosition;
            }

            for (int n = 0; n < 8; n++)
            {
                tokens[n].transform.position = _tokenPositions[n];
            }
        }

        public void SetTokenActives(bool active)
        {
            for (int n = 0; n < 8; n++)
            {
                tokens[n].SetActive(active);
            }
        }
    }
}
