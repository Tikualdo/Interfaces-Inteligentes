using UnityEngine;

public class TriggerCube : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Contains("Lich"))
        {
            Debug.Log("Cubo sobre Lich");
            EventManagerv2.TriggerLichEvent();
        }
        else if (other.name.Contains("Nórdico"))
        {
            Debug.Log("Cubo sobre Nórdico");
            EventManagerv2.TriggerFighterEvent();
        }
    }
}
