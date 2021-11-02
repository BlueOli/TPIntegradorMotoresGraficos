using UnityEngine;

public class SaltoJugador : MonoBehaviour
{
    public LayerMask capaPiso;
    public float magnitudSalto;
    public CapsuleCollider col;
    private Rigidbody rb;
    private int contadorSaltoAire = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        col = GetComponent<CapsuleCollider>();
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && contadorSaltoAire < 1) //Puede realizar un salto normal y uno en el aire
        {
            rb.AddForce(Vector3.up * magnitudSalto, ForceMode.Impulse);
            contadorSaltoAire++;
        }

        if (EstaEnPiso())
        {
            contadorSaltoAire = 0; //Reset de contador
        }

    }

    private bool EstaEnPiso() //Verificamos si está en el piso
    {
        return Physics.CheckCapsule(col.bounds.center, new Vector3(col.bounds.center.x,
        col.bounds.min.y, col.bounds.center.z), col.radius * .9f, capaPiso);
    }

}