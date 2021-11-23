using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.PostProcessing;


public class ControlPostProcessing : MonoBehaviour
{
    public GameObject postProcessing;
    public bool togglePostProcessing = false;
    void Update()
    {
        if (Input.GetMouseButtonDown(1)) togglePostProcessing = !togglePostProcessing;
        if (togglePostProcessing)
        {
            postProcessing.SetActive(true);
        }
        else
        {
            postProcessing.SetActive(false);
        }
    }
}
