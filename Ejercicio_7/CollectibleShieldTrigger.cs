using UnityEngine;

public class CollectibleShieldTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Nórdico"))
        {
            PlayerController player = other.GetComponent<PlayerController>();

            if (player != null)
            {
                if (gameObject.CompareTag("Tipo 1"))
                {
                    player.AddScore(5);
                }
                else if (gameObject.CompareTag("Tipo 2"))
                {
                    player.AddScore(10);
                }

                Destroy(gameObject);
            }
        }
    }
}