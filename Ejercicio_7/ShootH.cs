using UnityEngine;
using UnityEngine.InputSystem;

public class ShootH : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Mapeo de tecla H
        if (Keyboard.current.hKey.wasPressedThisFrame)
        {
            Disparar();
        }
    }
    void Disparar()
    {
        Debug.Log("Piu Piu");
    }

}
