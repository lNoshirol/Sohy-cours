using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPad : MonoBehaviour
{
    GameObject monCube;
    public float vitesse;
    public float sensibilité;
    // Start is called before the first frame update
    void Start()
    {
        monCube = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate (Vector3.forward * vitesse);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * vitesse);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * sensibilité);

        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * sensibilité);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(Vector3.right * sensibilité);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(Vector3.left * sensibilité);
        }
    }
}
