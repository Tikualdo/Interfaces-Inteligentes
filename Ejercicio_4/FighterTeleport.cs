using UnityEngine;

public class FighterTeleport : MonoBehaviour
{
    [Tooltip("El objetivo al que se teletransportarán todos los Nórdicos")]
    public Transform objetivo;

    // Detecta colisión física
    private void OnCollisionEnter(Collision collision)
    {
        TeletransportarNordicos();
    }

    // Detecta colisión tipo trigger
    private void OnTriggerEnter(Collider other)
    {
        TeletransportarNordicos();
    }

    private void TeletransportarNordicos()
    {
        if (objetivo == null)
        {
            Debug.LogWarning("⚠️ No se ha asignado un objetivo para el teletransporte.");
            return;
        }

        // Encuentra todos los objetos con tag "Nórdico"
        GameObject[] nordicos = GameObject.FindGameObjectsWithTag("Nórdico");

        foreach (GameObject nordico in nordicos)
        {
            nordico.transform.position = objetivo.position;
        }

        Debug.Log("⚡ Todos los Nórdicos teletransportados a " + objetivo.name);
    }
}
