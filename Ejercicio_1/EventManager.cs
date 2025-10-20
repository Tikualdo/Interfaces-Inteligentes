using System;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public static Action OnCylinderTriggered; // Evento global

    public static void TriggerCylinderEvent()
    {
        OnCylinderTriggered?.Invoke();
    }
}
