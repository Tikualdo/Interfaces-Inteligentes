using UnityEngine;
using System.Collections;

public class SphereBehaviour : MonoBehaviour
{
    public Transform objetivoTipo1;
    public Transform cilindro;
    public float velocidad = 3f;

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
        if (gameObject.CompareTag("Tipo 1") && objetivoTipo1 != null)
        {
            StopAllCoroutines();
            StartCoroutine(MoverHacia(objetivoTipo1.position));
        }
        else if (gameObject.CompareTag("Tipo 2") && cilindro != null)
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
