using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class ShowSphereAtributes : MonoBehaviour
{
    [Header("Vectores a analizar")]
    public Vector3 vector1;
    public Vector3 vector2;
    
    [Header("Resultados calculados")]
    [SerializeField] private float magnitud1;
    [SerializeField] private float magnitud2;
    [SerializeField] private float angulo;
    [SerializeField] private float distancia;
    [SerializeField] private string vectorMayorAltura;
    
    void Start()
    {
        // Calcular y asignar las magnitudes de los vectores
        magnitud1 = vector1.magnitude;
        magnitud2 = vector2.magnitude;
        Debug.Log("Magnitud del vector 1: " + magnitud1);
        Debug.Log("Magnitud del vector 2: " + magnitud2);

        // Calcular y asignar el ángulo entre los vectores
        angulo = Vector3.Angle(vector1, vector2);
        Debug.Log("Ángulo entre los vectores: " + angulo + " grados");

        // Calcular y asignar la distancia entre los vectores
        distancia = Vector3.Distance(vector1, vector2);
        Debug.Log("Distancia entre los vectores: " + distancia);

        // Determinar qué vector está a mayor altura
        if (vector1.y > vector2.y)
        {
            vectorMayorAltura = "El vector 1 está a mayor altura.";
            Debug.Log("El vector 1 está a mayor altura.");
        }
        else if (vector1.y < vector2.y)
        {
            vectorMayorAltura = "El vector 2 está a mayor altura.";
            Debug.Log("El vector 2 está a mayor altura.");
        }
        else
        {
            vectorMayorAltura = "Ambos vectores están a la misma altura.";
            Debug.Log("Ambos vectores están a la misma altura.");
        }
    }

    void Update()
    {
        
    }
}
