using UnityEngine;
using System.Collections;

public class FighterBehaviour : MonoBehaviour
{
    public Transform objetivoTipo1;
    public Transform cilindro;
    public float velocidad = 2f;

    void OnEnable()
    {
        EventManager.OnCylinderTriggered += OnCylinderCollision;
    }

    void OnDisable()
    {
        EventManager.OnCylinderTriggered -= OnCylinderCollision;
    }

    void OnCylinderCollision()
    {
        if (gameObject.CompareTag("Nórdico") && objetivoTipo1 != null)
        {
            StopAllCoroutines();
            StartCoroutine(MoverHacia(objetivoTipo1.position));
        }
        else if (gameObject.CompareTag("Lich") && cilindro != null)
        {
            StopAllCoroutines();
            StartCoroutine(MoverHacia(cilindro.position));
        }
    }

    IEnumerator MoverHacia(Vector3 destino)
    {
        while (Vector3.Distance(transform.position, destino) > 0.1f)
        {
            transform.position = Vector3.MoveTowards(transform.position, destino, velocidad * Time.deltaTime);
            yield return null;
        }
    }
}
