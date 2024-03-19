using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoSc : MonoBehaviour
{
    public float vitesse = 0.05f;
    public Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        int MaPremiereVariable = 5;
        Debug.Log(MaPremiereVariable);
        float A = 10.123f;
        float B = 10.0f;
        Debug.Log(A - B);
        float rayon = 1.25f;
        Debug.Log(rayon * Mathf.PI * 2.0f);
        string prenom = "Quentin";
        string nom = "Lumineau";
        GameObject cube = this.gameObject;
        cube.name = nom + " " + prenom;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * vitesse;
    }
}
