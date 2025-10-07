using UnityEngine;

public class ShowVectorDisplay : MonoBehaviour
{
    [Header("Posición de la esfera")]
    [SerializeField] private Vector3 posicionEsfera;
    [SerializeField] private float posX;
    [SerializeField] private float posY;
    [SerializeField] private float posZ;
    
    void Start()
    {
        posicionEsfera = transform.position;
        posX = transform.position.x;
        posY = transform.position.y;
        posZ = transform.position.z;        
        Debug.Log("Posición de la esfera: " + posicionEsfera);
    }

    void Update()
    {
        
    }
}
