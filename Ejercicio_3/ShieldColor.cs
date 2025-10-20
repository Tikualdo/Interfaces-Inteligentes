using UnityEngine;

public class ShieldColor : MonoBehaviour
{
    private Renderer shieldRenderer;

    void Start()
    {
        // Guardamos el Renderer del escudo al inicio
        shieldRenderer = GetComponent<Renderer>();
    }

    private void OnTriggerEnter(Collider other)
    {
            Debug.Log("Escudo colisionó con Nórdico");
        if (other.CompareTag("Nórdico"))
        {

            if (shieldRenderer != null)
            {
                Color randomColor = new Color(Random.value, Random.value, Random.value);
                shieldRenderer.material.color = randomColor;
            }
        }
    }
}
