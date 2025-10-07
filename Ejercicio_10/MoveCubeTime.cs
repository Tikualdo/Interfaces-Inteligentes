using UnityEngine;
using UnityEngine.InputSystem;
public class MoveCubeTime : MonoBehaviour
{
    [Header("Configuración de movimiento")]
    public float speed = 5.0f;
    
    [Header("Referencias a objetos")]
    public GameObject cube;    
    void Start()
    {
        cube = GameObject.FindWithTag("Cubo");
    }

    void Update()
    {   
        // Movimiento con WASD
        MoveWithWASD();
    }
    
    void MoveWithWASD()
    {
        if (cube == null) return;

        Vector3 movement = Vector3.zero;
        
        // W/S - movimiento VERTICAL (eje Y)
        if (Keyboard.current.wKey.isPressed)
            movement.y += 1f;
        if (Keyboard.current.sKey.isPressed)
            movement.y -= 1f;
            
        // A/D - movimiento HORIZONTAL (eje X)
        if (Keyboard.current.aKey.isPressed)
            movement.x -= 1f;
        if (Keyboard.current.dKey.isPressed)
            movement.x += 1f;
        
        // Aplicar movimiento
        cube.transform.Translate(movement * speed * Time.deltaTime);
    }
}
