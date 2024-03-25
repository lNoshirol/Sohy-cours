using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RandomCubeCreator : MonoBehaviour
{
    public int creatCube;
    public float tailleMax;
    public float tailleMin;
    public float cubeSpace;
    public List<GameObject> cubeList;
    // Start is called before the first frame update
    void Start()
    {
        for (int cubeCount = 0; cubeCount < creatCube; cubeCount++)
        {
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            float cubeTaille = Random.Range(tailleMin, tailleMax);
            Vector3 cubeScale;
            cubeScale.x = cubeTaille;
            cubeScale.y = cubeTaille;
            cubeScale.z = cubeTaille;
            cube.transform.localScale = cubeScale;
            cubeList.Add(cube);
        }
        int listCount = 0;
        foreach (GameObject cube in cubeList)
        {
            cube.transform.position = new Vector3(listCount * cubeSpace, transform.position.y, transform.position.z);
            listCount++;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
