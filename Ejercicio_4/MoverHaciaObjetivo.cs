using UnityEngine;

public class MoverHaciaObjetivo : MonoBehaviour
{
    [Tooltip("El objeto al que este cubo debe acercarse")]
    public Transform objetivo;

    [Tooltip("Velocidad de movimiento en unidades por segundo")]
    public float velocidad = 2f;

    void Update()
    {
        if (objetivo == null) return;

        // Calcula la posición hacia la que moverse cada frame
        transform.position = Vector3.MoveTowards(
            transform.position, 
            objetivo.position, 
            velocidad * Time.deltaTime
        );
    }
}
