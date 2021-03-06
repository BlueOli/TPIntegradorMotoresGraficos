using UnityEngine;

public class ControlCamara : MonoBehaviour
{
    Vector2 mouseMirar;
    Vector2 suavidadV;

    public float sensibilidad = 5.0f;
    public float suavizado = 2.0f;
    public bool toggleZoom = false;

    public GameObject jugador;
    public Camera camera;

    void Start()
    {
        jugador = this.transform.parent.gameObject;
    }

    void Update()
    {
        var md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

        md = Vector2.Scale(md, new Vector2(sensibilidad * suavizado, sensibilidad * suavizado));

        suavidadV.x = Mathf.Lerp(suavidadV.x, md.x, 1f / suavizado);
        suavidadV.y = Mathf.Lerp(suavidadV.y, md.y, 1f / suavizado);

        mouseMirar += suavidadV;
        mouseMirar.y = Mathf.Clamp(mouseMirar.y, -90f, 90f);
        transform.localRotation = Quaternion.AngleAxis(-mouseMirar.y, Vector3.right);
        jugador.transform.rotation = Quaternion.AngleAxis(mouseMirar.x, jugador.transform.up);


        //Zoom!
        if (Input.GetMouseButtonDown(1)) toggleZoom = !toggleZoom;

        if (toggleZoom)
        {
            camera.fieldOfView = 25;
        }
        else
        {
            camera.fieldOfView = 60;
        }


    }
}