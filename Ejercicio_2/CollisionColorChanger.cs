using UnityEngine;

public class CollisionColorChanger : MonoBehaviour
{
    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Método que se llama automáticamente cuando este objeto colisiona con otro
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"{gameObject.tag} colisionó con {collision.gameObject.tag}");

        // Cambiar el color del objeto con el que colisiona a un color aleatorio
        Renderer otherRend = collision.gameObject.GetComponent<Renderer>();
        if (otherRend != null)
        {
            otherRend.material.color = new Color(Random.value, Random.value, Random.value);
        }
        
        if (rend != null)
        {
            rend.material.color = new Color(Random.value, Random.value, Random.value);
        }
    }
}
