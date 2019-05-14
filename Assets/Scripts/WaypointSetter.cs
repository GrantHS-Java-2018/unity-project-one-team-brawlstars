using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;

public class WaypointSetter : MonoBehaviour
{
    // Start is called before the first frame update
    
    public Vector3[] waypointPositions = new Vector3[40];
   
    private float previousX = 7.500001f;
    private float previousY = -5.430004f;

    //Material variable for making test spheres more clearly visible
    public Material testSphereMaterial;
    
    void Start()
    {
for (int n = 0; n < 40; n++) //This for loop simply positions waypoints so they can be referenced later for movement
        {
            //If statements tell the change in x or y for the next waypoint vs the previous one
            float deltaX = 0f;
            float deltaY = 0f;
            if (n == 0)
            {
                deltaX = -0.97f;
            }
            else if (n == 1 || n == 10)
            {
                deltaX = -1.585f;
            }
            else if (n > 1 && n < 10)
            {
                deltaX = -1.23f;
            }
            else if (n == 11 || n == 20)
            {
                deltaY = 1.585f;
            }
            else if (n > 11 && n < 20)
            {
                deltaY = 1.23f;
            }
            else if (n == 21 || n == 30)
            {
                deltaX = 1.585f;
            }
            else if (n > 21 && n < 30)
            {
                deltaX = 1.23f;
            }
            else if (n == 31)
            {
                deltaY = -1.585f;
            }
            else if (n > 31 && n < 40)
            {
                deltaY = -1.23f;
            }
           
            //Inserts waypoint position into the array
            waypointPositions[n] = new Vector3(previousX + deltaX, previousY + deltaY, 1f);
            previousX = waypointPositions[n].x;
            previousY = waypointPositions[n].y;
            
            //This block is for testing, will show circles where there are waypoints
            GameObject waypoint = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            waypoint.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
            waypoint.transform.position = waypointPositions[n];
            waypoint.GetComponent<MeshRenderer>().material = testSphereMaterial;
        }
    }
    //FOR FUTURE REFERENCE ON TILE SIZES
    //Half of a big square is 97 pixels, 97 units
    //Half of a small rectangle is 97 units vertically, and 123 units horizontally (61.5) is half
}
