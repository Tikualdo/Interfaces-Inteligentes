using UnityEngine;
using Vector3 = UnityEngine.Vector3;
using Random = UnityEngine.Random;


public class RandomColor : MonoBehaviour
{
    private Vector3 colorValues;
    void Start()
    {
        colorValues = new Vector3(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        GetComponent<Renderer>().material.color = new Color(colorValues.x, colorValues.y, colorValues.z);
    }


    public int framesToWait = 120;
    public int frameCounter = 0;
    void Update()
    {
        frameCounter++;
        if (frameCounter >= framesToWait) {
            frameCounter = 0;
            int index = Random.Range(0, 3);
            float newValue = Random.Range(0f, 1f);
            if (index == 0) colorValues.x = newValue;
            else if (index == 1) colorValues.y = newValue;
            else colorValues.z = newValue;
            GetComponent<Renderer>().material.color = new Color(colorValues.x, colorValues.y, colorValues.z);
        }
    }
}
