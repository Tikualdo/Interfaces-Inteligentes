using System;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public static Action OnCylinderTriggered;

    public static void TriggerCylinderEvent()
    {
        OnCylinderTriggered?.Invoke();
    }
}
