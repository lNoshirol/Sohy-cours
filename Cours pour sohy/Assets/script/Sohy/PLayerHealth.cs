using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerHealth : MonoBehaviour
{
    public int currenthealth;
    // Start is called before the first frame update
    void Start()
    {
        switch (currenthealth)
        {
            case >= 100:
                Debug.Log("Vous �tes en sacr�ment bonne sant� !");
                break;
            case >50:
                Debug.Log("Tout devrait bien se passer.");
                break;
            case > 20:
                Debug.Log("Une petite potion de soin pourrait faire du bien...");
                break;
            case > 0:
                Debug.Log("Fuyez, pauvres fous !");
                break;
            case 0:
                Debug.Log("Vous �tes morts !");
                break;
            case < 0:
                Debug.Log("Vous �tes super morts !");

                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
