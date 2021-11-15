using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class GestorPersistencia : MonoBehaviour
{
    public static GestorPersistencia instancia;
    public DataPersistencia data;
    string archivoDatos = "save.dat";
    public GameObject personaje;
    public Vector3 currentPos;
    public Vector3 lastPos;

    private void Awake()
    {
        if (instancia == null)
        {
            DontDestroyOnLoad(this.gameObject);
            instancia = this;
        }
        else if (instancia != this)
            Destroy(this.gameObject);

        CargarDataPersistencia();
        data.totalDistance -= 709; // Fix de Lectura
    }

    private void Update()
    {
        currentPos = personaje.transform.position;
        data.totalDistance += Vector3.Distance(currentPos, lastPos);
        data.totalTime += Time.deltaTime;
        lastPos = currentPos;
        GuardarDataPersistencia();
    }

    public void GuardarDataPersistencia()
    {
        string filePath = Application.persistentDataPath + "/" + archivoDatos;
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(filePath);
        bf.Serialize(file, data);
        file.Close();
        Debug.Log("Datos guardados");
    }

    public void CargarDataPersistencia()
    {
        string filePath = Application.persistentDataPath + "/" + archivoDatos;
        BinaryFormatter bf = new BinaryFormatter();
        if (File.Exists(filePath))
        {
            FileStream file = File.Open(filePath, FileMode.Open);
            DataPersistencia cargado = (DataPersistencia)bf.Deserialize(file);
            data = cargado;
            file.Close();
            Debug.Log("Datos cargados");
        }
    }

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 400, 400), "Tiempo jugado: " + Mathf.Round((data.totalTime / 60) * 100f)/100f + " minutos" + "\nDistancia recorrida: " + data.totalDistance);
    }
}


