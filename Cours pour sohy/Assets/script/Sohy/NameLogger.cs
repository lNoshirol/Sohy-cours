using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameLogger : MonoBehaviour
{
    public List<GameObject> objets;
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject nom in objets)
        {
            Debug.Log(nom.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
