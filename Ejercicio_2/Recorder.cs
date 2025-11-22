using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Recorder : MonoBehaviour
{
    private AudioSource audioSourceAltavoz;
    private string nombreMicrofono;
    private bool microfonoListo = false;

    void Start()
    {
        audioSourceAltavoz = GetComponent<AudioSource>();

        if (Microphone.devices.Length > 0)
        {
            nombreMicrofono = Microphone.devices[0];
            microfonoListo = true;
            Debug.Log("Micrófono detectado: " + nombreMicrofono);
        }
        else
        {
            Debug.LogError("¡No se ha detectado ningún micrófono!");
            return;
        }

        audioSourceAltavoz.loop = true;
        audioSourceAltavoz.mute = true;

        audioSourceAltavoz.clip = Microphone.Start(nombreMicrofono, true, 10, 44100);

        while (!(Microphone.GetPosition(nombreMicrofono) > 0)) { }
        
        audioSourceAltavoz.Play();
    }

    void Update()
    {
        if (!microfonoListo) return;

        if (Input.GetKey(KeyCode.R))
        {
            if (audioSourceAltavoz.mute)
            {
                audioSourceAltavoz.mute = false;
                Debug.Log("Altavoz ON (Tecla R pulsada)");
            }
        }
        else
        {
            if (!audioSourceAltavoz.mute)
            {
                audioSourceAltavoz.mute = true;
                Debug.Log("Altavoz OFF (Tecla R soltada)");
            }
        }
    }
}