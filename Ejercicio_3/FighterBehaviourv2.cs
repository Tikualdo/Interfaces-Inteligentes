using UnityEngine;
using System.Collections;

public class FighterBehaviourv2 : MonoBehaviour
{
    public Transform objetivoTipo1;
    public float velocidad = 2f;

    void OnEnable()
    {
        EventManagerv2.OnLichTriggered += OnLichCollision;
        EventManagerv2.OnFighterTriggered += OnFighterCollision;
    }

    void OnDisable()
    {
        EventManagerv2.OnLichTriggered -= OnLichCollision;
        EventManagerv2.OnFighterTriggered -= OnFighterCollision;
    }

    private void OnLichCollision()
    {
        if (gameObject.CompareTag("Nórdico") && objetivoTipo1 != null)
        {
            StopAllCoroutines();
            StartCoroutine(MoverHacia(objetivoTipo1.position));
        } else
        {
            Debug.LogWarning("⚠️ No se encontró ningún objeto con la etiqueta 'Nórdico'.")
        }
    }

    private void OnFighterCollision()
    {
        if (CompareTag("Nórdico"))
        {
            GameObject destinoTipo2 = GameObject.FindGameObjectWithTag("Tipo 2");

            if (destinoTipo2 != null)
            {
                StopAllCoroutines();
                StartCoroutine(MoverHacia(destinoTipo2.transform.position));
            }
            else
            {
                Debug.LogWarning("⚠️ No se encontró ningún objeto con la etiqueta 'Tipo 2'.");
            }
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
