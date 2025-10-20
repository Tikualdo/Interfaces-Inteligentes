using System;
using UnityEngine;

public class EventManagerv2 : MonoBehaviour
{
    public static Action OnLichTriggered;
    public static Action OnFighterTriggered;

    public static void TriggerLichEvent()
    {
        OnLichTriggered?.Invoke();
    }

    public static void TriggerFighterEvent()
    {
        OnFighterTriggered?.Invoke();
    }
}
