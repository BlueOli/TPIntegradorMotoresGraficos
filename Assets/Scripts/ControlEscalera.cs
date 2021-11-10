using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlEscalera : MonoBehaviour
{
    public Animator myAnimationController;

    public void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            myAnimationController.SetBool("EscaleraBool", true);
        }
    }
}