using UnityEngine;

public class FighterTeleport : MonoBehaviour
{
    public Transform objetivo;

    private void OnCollisionEnter(Collision collision)
    {
        TeletransportarNordicos();
    }

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
