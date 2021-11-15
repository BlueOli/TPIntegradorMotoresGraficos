using UnityEngine;

public class ControlJugador : MonoBehaviour
{
    public float rapidezDesplazamiento = 10.0f;
    
    public Camera camaraPrimeraPersona;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float movimientoAdelanteAtras = Input.GetAxis("Vertical") * rapidezDesplazamiento;
        float movimientoCostados = Input.GetAxis("Horizontal") * rapidezDesplazamiento;

        movimientoAdelanteAtras *= Time.deltaTime;
        movimientoCostados *= Time.deltaTime;

        transform.Translate(movimientoCostados, 0, movimientoAdelanteAtras);

        if (Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None;
        }

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = camaraPrimeraPersona.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
            RaycastHit hit;

            if ((Physics.Raycast(ray, out hit) == true))
            {
                Debug.Log("El rayo tocó al objeto: " + hit.collider.tag);
                if(hit.collider.tag == "TP1")
                {
                    transform.position = new Vector3(527f, 90f, 125f);
                }
            }

            if ((Physics.Raycast(ray, out hit) == true))
            {
                Debug.Log("El rayo tocó al objeto: " + hit.collider.tag);
                if (hit.collider.tag == "TP2")
                {
                    transform.position = new Vector3(515f, 99f, 156f);
                }
            }

            if ((Physics.Raycast(ray, out hit) == true))
            {
                Debug.Log("El rayo tocó al objeto: " + hit.collider.tag);
                if (hit.collider.tag == "TP3")
                {
                    transform.position = new Vector3(558f, 109f, 168f);
                }
            }
        }

    }
}