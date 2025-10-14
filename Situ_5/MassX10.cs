using UnityEngine;

public class MassX10 : MonoBehaviour
{
    public string cubeTag = "Cubo";
    public float cubeMass = 1f;
    public string sphereTag = "Esfera";
    public float sphereMass = 1f;
    [Tooltip("Factor multiplicador: masaEsfera = masaCubo * factor")]
    float factor = 10f;
    [Tooltip("Si está activo, aplicará la relación en Start")]
    public bool applyOnStart = true;
    [Tooltip("Si está activo, actualizará la masa cada frame (útil para pruebas)")]

    Rigidbody rbCube;
    Rigidbody rbSphere;
    // Auxiliar para detectar cambios en el Inspector / editores
    float lastCubeMass = -1f;

    void Start()
    {
        ApplyMassFromCube();
    }

    void Update()
    {
        
    }

    public void ApplyMassFromCube(bool applyFieldValue = false)
    {
        GameObject cubeObj = null;
        GameObject sphereObj = null;

        try
        {
            cubeObj = GameObject.FindWithTag(cubeTag);
        }
        catch { }

        try
        {
            sphereObj = GameObject.FindWithTag(sphereTag);
        }
        catch { }

        if (cubeObj == null)
        {
            Debug.LogWarning($"[MassX10] No se encontró objeto con tag '{cubeTag}'");
            return;
        }

        if (sphereObj == null)
        {
            Debug.LogWarning($"[MassX10] No se encontró objeto con tag '{sphereTag}'");
            return;
        }

        rbCube = cubeObj.GetComponent<Rigidbody>();
        rbSphere = sphereObj.GetComponent<Rigidbody>();

        if (rbCube == null)
        {
            Debug.LogWarning($"[MassX10] El objeto con tag '{cubeTag}' no tiene Rigidbody");
            return;
        }

        if (rbSphere == null)
        {
            Debug.LogWarning($"[MassX10] El objeto con tag '{sphereTag}' no tiene Rigidbody");
            return;
        }

        if (applyFieldValue)
        {
            rbCube.mass = cubeMass;
        }
        else
        {
            cubeMass = rbCube.mass;
        }

        rbSphere.mass = cubeMass * factor;
        this.sphereMass = rbSphere.mass;
        lastCubeMass = cubeMass;

        Debug.Log($"[MassX10] Masa del cubo: {cubeMass} -> Masa de la esfera: {rbSphere.mass} (factor {factor})");
    }

    #if UNITY_EDITOR
        // Se ejecuta en el editor cuando cambian valores en el Inspector
        void OnValidate()
        {
            // Evitar llamadas innecesarias al cargar por primera vez
            if (!Application.isPlaying)
            {
                if (!Mathf.Approximately(cubeMass, lastCubeMass))
                {
                    // Aplicar la masa modificada en el Inspector
                    ApplyMassFromCube(true);
                }
            }
        }
    #endif
}
