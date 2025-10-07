using UnityEngine;
using UnityEngine.InputSystem;

public class VelocityProductAxesCube : MonoBehaviour
{
    [Header("Configuración del cubo")]
    public float velocity = 1.0f;
    
    void Start()
    {
        
    }

    void Update()
    {
        // Obtener valores de los ejes en cada frame
        float horizontalInput = 0f;
        float verticalInput = 0f;
        
        // Calcular valores de input
        if (Keyboard.current.rightArrowKey.isPressed)
            horizontalInput = 1f;
        else if (Keyboard.current.leftArrowKey.isPressed)
            horizontalInput = -1f;
            
        if (Keyboard.current.upArrowKey.isPressed)
            verticalInput = 1f;
        else if (Keyboard.current.downArrowKey.isPressed)
            verticalInput = -1f;

        // Detectar teclas y mostrar resultados
        if (Keyboard.current.upArrowKey.wasPressedThisFrame)
        {
            float result = velocity * verticalInput;
            Debug.Log("Flecha Arriba: " + result);
        }

        if (Keyboard.current.downArrowKey.wasPressedThisFrame)
        {
            float result = velocity * verticalInput;
            Debug.Log("Flecha Abajo: " + result);
        }

        if (Keyboard.current.leftArrowKey.wasPressedThisFrame)
        {
            float result = velocity * horizontalInput;
            Debug.Log("Flecha Izquierda: " + result);
        }

        if (Keyboard.current.rightArrowKey.wasPressedThisFrame)
        {
            float result = velocity * horizontalInput;
            Debug.Log("Flecha Derecha: " + result);
        }
    }
}
