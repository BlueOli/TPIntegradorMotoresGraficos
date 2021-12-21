using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasajeArcos : MonoBehaviour
{
    public Light refLight;

    public void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            if (!GetComponent<Light>().enabled && refLight.enabled)
            {
                GetComponent<Light>().enabled = !GetComponent<Light>().enabled;
            }
        }
    }

}