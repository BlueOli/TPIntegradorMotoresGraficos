using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NivelA : MonoBehaviour
{
    public Light lightA;
    public Light lightB;
    public Light lightC;
    public Light lightD;
    public Light lightE;
    public Light lightF;
    public bool levelPassed;
    public Animator myAnimationController;
 
    void Update()
    {
        if(!levelPassed && lightA.enabled && lightB.enabled && lightC.enabled && lightD.enabled && lightE.enabled && lightF.enabled)
        {
            levelPassed = !levelPassed;
            myAnimationController.SetBool("Completado", true);
        }
    }

}
