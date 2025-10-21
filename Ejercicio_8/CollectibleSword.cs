using UnityEngine;

public class CollectibleSword : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Nórdico"))
        {
            PlayerController player = other.GetComponent<PlayerController>();

            if (player != null)
            {
                Debug.Log("Espada recogida");
                Destroy(gameObject);
            }
        }
    }
}
