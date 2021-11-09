using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasajeArco : MonoBehaviour
{
    public void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            if (!GetComponent<Light>().enabled) {
                GetComponent<Light>().enabled = !GetComponent<Light>().enabled;
            }
        }
    }

}
