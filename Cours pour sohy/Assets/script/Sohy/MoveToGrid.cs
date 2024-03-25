using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public List<GameObject> targets;
    public Vector3 gridSize;
    public float distanceBetweenPoints = 1.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int cubeCount = 0;
        for (int x = 0; x<gridSize.x; x++)
        {
            for (int y = 0; y<gridSize.y; y++)
            {
                for (int z = 0; z<gridSize.z; z++)
                {
                    Vector3 newPosition = new Vector3(x*distanceBetweenPoints, y*distanceBetweenPoints, z*distanceBetweenPoints);
                    targets[cubeCount].transform.position = newPosition;
                    cubeCount++;
                }
            }
        }
    }
}
