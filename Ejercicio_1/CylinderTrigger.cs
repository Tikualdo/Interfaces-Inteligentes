using UnityEngine;

public class CylinderTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.name.Contains("Cube"))
        {
            Debug.Log("[Cylinder] ¡Colisión detectada con el cubo!");
            EventManager.TriggerCylinderEvent();
        }
    }
}
