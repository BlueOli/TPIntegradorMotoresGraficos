using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horario : MonoBehaviour
{
    public GameObject sol;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Estoy");
        Debug.Log(sol.transform.rotation.eulerAngles[0]);
    }
}
