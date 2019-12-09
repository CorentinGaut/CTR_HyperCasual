using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GenerateBle : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] ble;
    public GameObject earth;

    public int meridiens;
    public int paralleles;
    public float rayon;

    public int nbDetruis = 0;
    public int nbGenere;
    public Text textPourcentage;

    void Start()
    {
        generateBle();
    }

    // Update is called once per frame
    void Update()
    {
        textPourcentage.text = ((nbDetruis * 100 / nbGenere).ToString() + " %");
    }

    void generateBle()
    {
        for (int y = 0; y < paralleles; y++)
        {
            for (int x = 0; x < meridiens; x++)
            {
                if (y < 7)
                {
                    x += (7 - y);
                }
                if (y > paralleles - 7)
                {
                    x +=  (7 - (paralleles - y));
                }
                //x += (5 - y); 
                float phi = Mathf.PI * y / paralleles;
                float theta = 2.0f * Mathf.PI * x / meridiens;

                Vector3 pos = new Vector3(rayon * Mathf.Sin(phi) * Mathf.Cos(theta), rayon * Mathf.Cos(phi), rayon * Mathf.Sin(phi) * Mathf.Sin(theta));
                pos += new Vector3(Random.Range(-0.10f, 0.10f), Random.Range(-0.10f, 0.10f), Random.Range(-0.10f, 0.10f));

                Vector3 normal = pos - earth.transform.position;
                int radmBle = Random.Range(0, 3);
                GameObject bleInstance = Instantiate(ble[radmBle], pos, Quaternion.identity);
                nbGenere++;
                bleInstance.transform.up = normal;

                bleInstance.transform.Rotate(new Vector3(0, 1, 0), Random.Range(0.0f, 360.0f));

            }
        }
    }
}
