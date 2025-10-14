using UnityEngine;

public class Launcher : MonoBehaviour
{
    public Rigidbody[] objetos;
    public float fuerza = 500f;

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
                
                rb.linearVelocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;

                rb.AddForce(Vector3.forward * fuerza);
            }
        }
    }
}
