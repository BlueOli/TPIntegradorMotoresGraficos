using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlJuego : MonoBehaviour
{

    public GameObject personaje;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r")) //Reset
        {
            ComenzarJuego();
        }
    }

    void ComenzarJuego() //Instancio todas mis variables necesarias
    {
        personaje.transform.position = new Vector3(500f, 57f, 500f);
        personaje.transform.localScale = new Vector3(1f, 1f, 1f);
    }
}
