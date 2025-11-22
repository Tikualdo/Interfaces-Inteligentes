using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class TV : MonoBehaviour
{
    private Material tvMaterial;
    private WebCamTexture webcamTexture;
    private string savePath;
    
    int captureCounter = 1;

    void Start()
    {
        Renderer renderer = GetComponent<Renderer>();
        if (renderer != null)
        {
            tvMaterial = renderer.material;
        }
        else
        {
            Debug.LogError("Este objeto no tiene Renderer. Asegúrate de poner el script en un Cubo o Plano.");
        }

        savePath = Application.dataPath + "/"; 

        WebCamDevice[] devices = WebCamTexture.devices;

        if (devices.Length > 0)
        {
            Debug.Log("Cámara detectada: " + devices[0].name);

            webcamTexture = new WebCamTexture(devices[0].name);
        }
        else
        {
            Debug.LogError("No se ha detectado ninguna cámara web.");
        }
    }

    void Update()
    {
        if (webcamTexture == null) return;

        if (Input.GetKeyDown(KeyCode.Z)) 
        {
            tvMaterial.mainTexture = webcamTexture;
            
            webcamTexture.Play();
            Debug.Log("Cámara encendida (Play)");
        }

        if (Input.GetKeyDown(KeyCode.P)) 
        {
            webcamTexture.Stop();
            Debug.Log("Cámara detenida (Stop)");
        }

        if (Input.GetKeyDown(KeyCode.X)) 
        {
            if (webcamTexture.isPlaying)
            {
                TomarFotograma();
            }
            else
            {
                Debug.LogWarning("Enciende la cámara (S) antes de tomar una foto.");
            }
        }
    }

    void TomarFotograma()
    {
        Texture2D snapshot = new Texture2D(webcamTexture.width, webcamTexture.height);

        snapshot.SetPixels(webcamTexture.GetPixels());

        snapshot.Apply();

        byte[] bytes = snapshot.EncodeToPNG();

        string fileName = savePath + "captura_" + captureCounter.ToString() + ".png";
        File.WriteAllBytes(fileName, bytes);

        Debug.Log("Foto guardada en: " + fileName);

        captureCounter++;
    }
}