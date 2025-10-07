using UnityEngine;

public class DistanceVectorSphere : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Obtener los objetos
        GameObject cube = GameObject.FindWithTag("Cubo");
        GameObject cylinder = GameObject.FindWithTag("Cilindro");

        // Obtener las transformaciones
        Transform transformCube = cube.transform;
        Transform transformCylinder = cylinder.transform;

        // Obtener las posiciones
        Vector3 positionEsphere = transform.position;
        Vector3 positionCube = transformCube.position;
        Vector3 positionCylinder = transformCylinder.position;

        // Calcular la distancia
        float distanceCube = Vector3.Distance(positionEsphere, positionCube);
        float distanceCylinder = Vector3.Distance(positionEsphere, positionCylinder);

        Debug.Log("Distancia entre la esfera y el cubo: " + distanceCube);
        Debug.Log("Distancia entre la esfera y el cilindro: " + distanceCylinder);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
