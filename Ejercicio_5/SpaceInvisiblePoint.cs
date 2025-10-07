using UnityEngine;
using UnityEngine.InputSystem;

public class SpaceInvisiblePoint : MonoBehaviour
{
    [Header("Objetos a mover")]
    public GameObject sphere;
    public GameObject cube;
    public GameObject cylinder;

    [Header("Posiciones de desplazamiento")]
    public Vector3 sphereDisplacement;
    public Vector3 cubeDisplacement;
    public Vector3 cylinderDisplacement;
    
    // Variables para guardar posiciones originales
    private Vector3 originalSpherePosition;
    private Vector3 originalCubePosition;
    private Vector3 originalCylinderPosition;
    
    void Start()
    {
        // Buscar los objetos por tag
        sphere = GameObject.FindWithTag("Esfera");
        cube = GameObject.FindWithTag("Cubo");
        cylinder = GameObject.FindWithTag("Cilindro");
        
        // Guardar posiciones originales
        originalSpherePosition = sphere.transform.position;
        originalCubePosition = cube.transform.position;
        originalCylinderPosition = cylinder.transform.position;
    }

    void Update()
    {
        // Nuevo Input System - Detectar barra espaciadora
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            // Aplicar el desplazamiento
            sphere.transform.position = originalSpherePosition + sphereDisplacement;
            cube.transform.position = originalCubePosition + cubeDisplacement;
            cylinder.transform.position = originalCylinderPosition + cylinderDisplacement;
            
            Debug.Log("Objetos movidos a nuevas posiciones!");
        }
    }
}
