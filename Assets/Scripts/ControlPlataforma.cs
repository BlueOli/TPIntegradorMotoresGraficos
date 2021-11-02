using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlataforma : MonoBehaviour
{
    public GameObject jugador;
    public Animator myAnimationController; 

    public void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            myAnimationController.SetBool("PlataformaBool", true);
            jugador.transform.parent = transform;
        }
    }

    public void OnTriggerExit(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            myAnimationController.SetBool("PlataformaBool", false);
            jugador.transform.parent = null;
        }
    }

}
