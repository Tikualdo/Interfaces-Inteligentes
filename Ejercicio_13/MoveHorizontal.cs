using UnityEngine;
using UnityEngine.InputSystem;

public class MoveHorizontal : MonoBehaviour
{
    [Header("Configuración de movimiento")]
    public float moveSpeed = 5.0f;
    public float rotationSpeed = 90.0f;

    [Header("Referencias a objetos")]
    public GameObject targetObject;

    void Start()
    {
        // Buscar el objeto objetivo por tag
        if (targetObject == null)
            targetObject = GameObject.FindWithTag("Cubo");
    }

    void Update()
    {
        MoveWithHorizontalAxis();
    }

    void MoveWithHorizontalAxis()
    {
        if (targetObject == null) return;

        float horizontalInput = 0f;
        
        // Detectar input horizontal con Input System
        if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed)
            horizontalInput = -1f;
        else if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed)
            horizontalInput = 1f;

        // Girar el objeto usando el input horizontal
        float rotationAmount = horizontalInput * rotationSpeed * Time.deltaTime;
        
        // Rotar alrededor del eje Y (girar izquierda/derecha)
        targetObject.transform.Rotate(0, rotationAmount, 0);
        
        // Avanzar siempre hacia adelante
        Vector3 forwardDirection = targetObject.transform.forward;
        Vector3 forwardMovement = forwardDirection * moveSpeed * Time.deltaTime;
        targetObject.transform.Translate(forwardMovement, Space.World);
    }
}
