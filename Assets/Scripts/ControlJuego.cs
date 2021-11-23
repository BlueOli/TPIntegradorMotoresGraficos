using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        if (Input.GetKeyDown("escape")) //Reset
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }

        if (Input.GetKeyDown("r")) //Reset
        {
            ComenzarJuego();
        }

        if (personaje.transform.position.x > 990 || personaje.transform.position.x < 10)
        {
            ComenzarJuego();
        }

        if (personaje.transform.position.y > 990 || personaje.transform.position.y < 10)
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
