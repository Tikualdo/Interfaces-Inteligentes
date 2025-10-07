using UnityEngine;

using UnityEngine.InputSystem;
public class SeeYouSphere : MonoBehaviour
{
    [Header("Configuración de movimiento")]
    public float speedCube = 1.0f;
    public float speedSphere = 3.0f;

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
        // Mover la esfera con WASD para hacer pruebas
        MoveSphereWithWASD();
        
        // Mover el cubo hacia la esfera con rotación
        MoveCubeTowardsSphere();
    }

    void MoveSphereWithWASD()
    {
        if (sphere == null) return;

        Vector3 movement = Vector3.zero;
        
        if (Keyboard.current.wKey.isPressed)
            movement.z += 1f;
        if (Keyboard.current.sKey.isPressed)
            movement.z -= 1f;
        if (Keyboard.current.aKey.isPressed)
            movement.x -= 1f;
        if (Keyboard.current.dKey.isPressed)
            movement.x += 1f;
        
        sphere.transform.Translate(movement * speedSphere * Time.deltaTime);
    }
    
    void MoveCubeTowardsSphere()
    {
        if (cube == null || sphere == null) return;

        // El cubo mire hacia la esfera
        cube.transform.LookAt(sphere.transform);
        
        // Avanzar hacia adelante en el espacio local del cubo
        Vector3 forwardMovement = cube.transform.forward * speedCube * Time.deltaTime;
        
        // Aplicar el movimiento en espacio mundial
        cube.transform.Translate(forwardMovement, Space.World);
    }
}
