using UnityEngine;

public class FindSphere : MonoBehaviour
{
    [Header("Configuración de movimiento")]
    public float speed = 5.0f;
    
    [Header("Referencias a objetos")]
    public GameObject cube;
    public GameObject sphere;
    
    void Start()
    {
        // Buscar objetos por tag
        cube = GameObject.FindWithTag("Cubo");
        sphere = GameObject.FindWithTag("Esfera");
    }

    void Update()
    {   
        MoveCubeTowardsSphere();
    }
    
    void MoveCubeTowardsSphere()
    {
        if (cube == null || sphere == null) return;

        // Vector que une cubo con esfera
        Vector3 cubePosition = cube.transform.position;
        Vector3 spherePosition = sphere.transform.position;
        Vector3 directionVector = spherePosition - cubePosition;
        directionVector.y = 0f;
        
        // Normalizar el vector para que tenga magnitud 1
        Vector3 normalizedDirection = directionVector.normalized;
        Vector3 movement = normalizedDirection * speed * Time.deltaTime;
        cube.transform.Translate(movement);
    }
}
