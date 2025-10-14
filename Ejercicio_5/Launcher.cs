using UnityEngine;

public class Launcher : MonoBehaviour
{
    public Rigidbody[] objetos;  // Asigna aquí tus cubos/esferas
    public float fuerza = 500f;  // Fuerza de lanzamiento

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            foreach (Rigidbody rb in objetos)
            {
                if (rb == null)
                {
                    Debug.LogWarning("[Launcher] Hay un objeto sin asignar en el array.");
                    continue;
                }
                // Reinicia movimiento previo
                rb.linearVelocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;

                // Aplica una fuerza hacia adelante
                rb.AddForce(Vector3.forward * fuerza);
            }
        }
    }
}
