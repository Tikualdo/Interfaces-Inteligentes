using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class GuerreroController : MonoBehaviour
{
    [Header("Ajustes de Movimiento")]
    public float velocidad = 10.0f;
    public float suavizadoRotacion = 5.0f;
    
    public float zonaMuerta = 0.1f; 

    [Header("GPS")]
    public float latitudCentro = 28.482f;
    public float longitudCentro = -16.322f;
    public float radioPermitido = 0.002f;

    [Header("UI")]
    public TextMeshProUGUI debugText;

    private bool puedeMoverse = true;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        if (Accelerometer.current != null)
            InputSystem.EnableDevice(Accelerometer.current);

        Input.location.Start();

        Input.compass.enabled = true;
    }

    void Update()
    {
        CheckGPS();

        if (!puedeMoverse) return;

        float norteHeading = Input.compass.trueHeading;
        Quaternion targetRotation = Quaternion.Euler(0, norteHeading, 0);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * suavizadoRotacion);

        MoverConAcelerometro();

        if (debugText != null)
        {
            float lat = Input.location.lastData.latitude;
            float lon = Input.location.lastData.longitude;
            
            string debugInfo = $"Lat: {lat}\nLon: {lon}\nNorte: {norteHeading:F1}°";
            if(Accelerometer.current != null)
            {
                var ac = Accelerometer.current.acceleration.ReadValue();
                debugInfo += $"\nAcel X: {ac.x:F2} | Y: {ac.y:F2}"; 
            }
            
            debugText.text = debugInfo;
        }
    }

    void MoverConAcelerometro()
    {
        if (Accelerometer.current == null) return;

        Vector3 aceleracion = Accelerometer.current.acceleration.ReadValue();

        float moveZ = -aceleracion.y;
        float moveX = aceleracion.x;

        if (Mathf.Abs(moveZ) < zonaMuerta) moveZ = 0;
        if (Mathf.Abs(moveX) < zonaMuerta) moveX = 0;

        Vector3 movimiento = new Vector3(moveX, 0, moveZ) * velocidad * Time.deltaTime;
        
        transform.Translate(movimiento, Space.Self);
    }

    void CheckGPS()
    {
        if (Input.location.status != LocationServiceStatus.Running) return;

        float latActual = Input.location.lastData.latitude;
        float lonActual = Input.location.lastData.longitude;

        float distLat = Mathf.Abs(latActual - latitudCentro);
        float distLon = Mathf.Abs(lonActual - longitudCentro);

        if (distLat > radioPermitido || distLon > radioPermitido)
        {
            puedeMoverse = false;
            if (debugText) debugText.color = Color.red;
        }
        else
        {
            puedeMoverse = true;
            if (debugText) debugText.color = Color.green;
        }
    }
}