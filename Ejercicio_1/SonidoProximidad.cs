using UnityEngine;

public class SonidoProximidad : MonoBehaviour
{
    [Header("Configuración")]
    public Transform miCuboJugador;
    public float distanciaMaxima = 15.0f;

    [Header("Audio")]
    public AudioClip sonidoAmbiente;
    [Range(0f, 1f)]
    public float volumenMaximo = 1.0f;

    private AudioSource _miAudioSource;

    void Start()
    {
        _miAudioSource = gameObject.AddComponent<AudioSource>();
        _miAudioSource.clip = sonidoAmbiente;
        _miAudioSource.loop = true;
        _miAudioSource.playOnAwake = false;
        
        _miAudioSource.spatialBlend = 0.0f;
        
        _miAudioSource.volume = 0;

        if (miCuboJugador == null)
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            if (player != null) miCuboJugador = player.transform;
        }

        if (sonidoAmbiente != null) _miAudioSource.Play();
    }

    void Update()
    {
        if (miCuboJugador == null) return;

        float distancia = Vector3.Distance(transform.position, miCuboJugador.position);

        if (distancia < distanciaMaxima)
        {
            float volumen = 1 - (distancia / distanciaMaxima);
            _miAudioSource.volume = volumen * volumenMaximo;
        }
        else
        {
            _miAudioSource.volume = 0;
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, distanciaMaxima);
    }
}