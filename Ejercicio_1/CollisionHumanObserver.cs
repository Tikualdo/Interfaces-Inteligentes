using UnityEngine;

public class CollisionHumanObserver : MonoBehaviour
{
    public ColissionHuman collision;
    Rigidbody rb;

    [Header("Configuración de Audio")]
    public AudioClip sonidoObjetivo; 
    
    // Variable privada para controlar el componente AudioSource
    private AudioSource _audioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        collision.OnCollisionTipo1 += ApplyAction1;
        collision.OnCollisionTipo2 += ApplyAction2;
        collision.RewardAction += ApplyScoreReward;

        _audioSource = GetComponent<AudioSource>();
        if (_audioSource != null && sonidoObjetivo != null)
        {
            _audioSource.clip = sonidoObjetivo;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void ApplyAction1()
    {
        GameObject[] shields1 = GameObject.FindGameObjectsWithTag("Tipo 1");
        GameObject firstShield = shields1[0];
        foreach (GameObject shield in shields1)
        {
            if (shield != firstShield)
            {
                Debug.Log("Moving shield: " + shield.name);
                shield.transform.position = Vector3.MoveTowards(shield.transform.position, firstShield.transform.position, Time.deltaTime * 15f);
            }
        }

        GameObject[] shields2 = GameObject.FindGameObjectsWithTag("Tipo 2 color");
        Debug.Log("Size of Tipo 2 shields: " + shields2.Length);
        foreach (GameObject shield in shields2)
        {
            Debug.Log("Changing color of shield");
            shield.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
        }
        if (_audioSource != null && sonidoObjetivo != null)
        {
            _audioSource.Play();
        }
    }

    void ApplyAction2()
    {
        GameObject[] shields1 = GameObject.FindGameObjectsWithTag("Tipo 1");
        foreach (GameObject shield in shields1)
        {
            Debug.Log("");
            GameObject lich = GameObject.FindGameObjectWithTag("Lich");
            if (lich != null)
            {
                Debug.Log("Found Lich: " + lich.name);
            }
            Vector3 lichPosition = lich.transform.position;
            shield.transform.position = Vector3.MoveTowards(shield.transform.position, lichPosition, -5f);

        }

        GameObject[] shields2 = GameObject.FindGameObjectsWithTag("Tipo 2");
        foreach (GameObject shield in shields2)
        {
            Vector3 shieldScale = shield.GetComponent<Transform>().localScale;
            shield.GetComponent<Transform>().localScale = new Vector3(shieldScale.x + 1f, shieldScale.y + 1f, shieldScale.z + 1f);
        }
    }

    void ApplyScoreReward()
    {
        GameObject[] shields1 = GameObject.FindGameObjectsWithTag("Tipo 1 (ejer5)");
        foreach (GameObject shield in shields1)
        {
            shield.transform.position = new Vector3(-20, 2, -39);

        }
    }
}
