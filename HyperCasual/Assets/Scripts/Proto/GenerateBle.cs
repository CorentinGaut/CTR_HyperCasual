using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateBle : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ble;
    public GameObject earth;

    public int meridiens;
    public int paralleles;
    public float rayon;

    void Start()
    {
        generateBle();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void generateBle()
    {
        for (int x = 1; x < paralleles; x++)
        {
            for (int y = 1; y < meridiens; y++)
            {
                if (x < 5 || x > paralleles - 5)
                {
                    y+=4;
                }
                float phi = 2.0f * Mathf.PI * x / paralleles;
                float theta = 2.0f * Mathf.PI * y / meridiens;
                Vector3 pos = new Vector3(rayon * Mathf.Sin(phi) * Mathf.Cos(theta), rayon * Mathf.Sin(phi) * Mathf.Sin(theta), rayon * Mathf.Cos(phi));
                Vector3 normal = pos - earth.transform.position;

                GameObject bleInstance = Instantiate(ble, pos, Quaternion.identity);
                bleInstance.transform.up = normal;
            }
        }
    }
}
