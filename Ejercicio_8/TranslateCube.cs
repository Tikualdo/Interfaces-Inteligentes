using UnityEngine;

public class TranslateCube : MonoBehaviour
{
    [Header("Configuración de movimiento")]
    public Vector3 moveDirection = new Vector3(1, 0, 0);
    
    public float speed = 2.0f;
    
    void Start()
    {
        // Asegurar que el cubo empiece en Y=0
        Vector3 startPosition = transform.position;
        startPosition.y = 0f;
        transform.position = startPosition;
        
        // Validar que la velocidad sea mayor que 1
        if (speed <= 1f)
        {
            Debug.LogWarning("La velocidad debería ser mayor que 1. Ajustando a 2.0f");
            speed = 2.0f;
        }
    }

    void Update()
    {
        // Trasladar el cubo en cada iteración
        Vector3 movement = moveDirection * speed * Time.deltaTime;
        
        // Aplicar el movimiento
        transform.Translate(movement);
    }
}
