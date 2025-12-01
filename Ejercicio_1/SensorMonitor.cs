using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using System.Text;

public class SensorMonitor : MonoBehaviour
{
    public TextMeshProUGUI statusText;

    void Start()
    {
        foreach (var device in InputSystem.devices)
        {
            if (device is Sensor)
            {
                InputSystem.EnableDevice(device);
            }
        }
    }

    void Update()
    {
        if (statusText == null) return;

        StringBuilder sb = new StringBuilder();
        sb.AppendLine("--- SENSORES ACTIVOS ---");

        foreach (var device in InputSystem.devices)
        {
            if (device is Sensor && device.enabled)
            {
                sb.Append($"<b>{device.name}</b>: ");

                if (device is Accelerometer acc)
                    sb.AppendLine(acc.acceleration.ReadValue().ToString("F2"));

                else if (device is UnityEngine.InputSystem.Gyroscope gyro)
                    sb.AppendLine(gyro.angularVelocity.ReadValue().ToString("F2"));

                else if (device is GravitySensor grav)
                    sb.AppendLine(grav.gravity.ReadValue().ToString("F2"));

                else if (device is LightSensor light)
                    sb.AppendLine($"{light.lightLevel.ReadValue()} lux");

                else if (device is StepCounter step)
                    sb.AppendLine($"{step.stepCounter.ReadValue()} pasos");

                else if (device is MagneticFieldSensor mag)
                    sb.AppendLine(mag.magneticField.ReadValue().ToString("F2"));
                
                else if (device is LinearAccelerationSensor linAcc)
                    sb.AppendLine(linAcc.acceleration.ReadValue().ToString("F2"));

                else if (device is ProximitySensor prox)
                    sb.AppendLine($"Distancia: {prox.distance.ReadValue()} cm");

                else if (device is AttitudeSensor attitude)
                    sb.AppendLine($"Rotación: {attitude.attitude.ReadValue()}");
                else
                    sb.AppendLine("(Valor genérico)");
            }
        }

        statusText.text = sb.ToString();
    }

    void OnDisable()
    {
        foreach (var device in InputSystem.devices)
        {
            if (device is Sensor)
                InputSystem.DisableDevice(device);
        }
    }
}