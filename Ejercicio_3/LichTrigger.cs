using UnityEngine;

public class LichTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.name.Contains("Cube"))
        {
            Debug.Log("[Lich] ¡Colisión detectada con el cubo!");
            EventManagerv2.TriggerLichEvent();
        }
    }
}
