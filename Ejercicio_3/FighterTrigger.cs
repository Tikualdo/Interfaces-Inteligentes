using UnityEngine;

public class FighterTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cube"))
        {
            Debug.Log("[Fighter] ¡Colisión detectada con el cubo!");
            EventManagerv2.TriggerFighterEvent();
        }
    }
}
