using UnityEngine;

public class CollectibleTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log($"{gameObject.name} recolectado por {other.name}");
            Destroy(gameObject); // opcional: destruir el objeto al recolectarlo
        }
    }
}
