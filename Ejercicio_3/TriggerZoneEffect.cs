using UnityEngine;

public class TriggerZoneEffect : MonoBehaviour
{
    public Renderer playerRenderer; // Renderer del personaje
    public Color triggerColor = Color.red; // Color al entrar
    public Light sceneLight; // Luz opcional
    public Color lightColor = Color.green; // Color de la luz al entrar

    private Color originalColor;
    private Color originalLightColor;

    void Start()
    {
        if (playerRenderer != null)
            originalColor = playerRenderer.material.color;
        if (sceneLight != null)
            originalLightColor = sceneLight.color;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (playerRenderer != null)
                playerRenderer.material.color = triggerColor;
            if (sceneLight != null)
                sceneLight.color = lightColor;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (playerRenderer != null)
                playerRenderer.material.color = originalColor;
            if (sceneLight != null)
                sceneLight.color = originalLightColor;
        }
    }
}
