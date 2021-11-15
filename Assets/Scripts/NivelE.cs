using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NivelE : MonoBehaviour
{
    public GameObject nivelE;
    public Animator myAnimationControllerNivelE;
    public Animator myAnimationController;
    bool levelIniciado = false;
    public bool levelPassed = false;
    public Light lightA;
    public Light lightB;
    public Light lightC;
    public Light lightD;
    public Light lightE;

    public void OnTriggerEnter(Collider col)
    {
        if (!levelIniciado)
        {
            if (col.CompareTag("Player"))
            {
                levelIniciado = !levelIniciado;
                myAnimationControllerNivelE.SetBool("Iniciado", true);
            }
        }
    }

    void Update()
    {
        if (!levelPassed && lightA.enabled && lightB.enabled && lightC.enabled && lightD.enabled && lightE.enabled)
        {
            levelPassed = !levelPassed;
            myAnimationController.SetBool("Completado", true);
        }
    }

}
