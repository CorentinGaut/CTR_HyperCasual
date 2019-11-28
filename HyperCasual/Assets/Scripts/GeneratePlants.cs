using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePlants : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject plants;
    public GameObject earth;
    void Start()
    {
        StartCoroutine("timeInstante");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator timeInstante()
    {
        for (int i = 1; i <= 3; i++)
        {
            yield return new WaitForSeconds(0.75f);

            GameObject right = Instantiate(plants,this.transform);
            GameObject left = Instantiate(plants, this.transform);

            right.transform.Rotate(new Vector3(0, 15 * i, 0));
            left.transform.Rotate(new Vector3(0, 15 * i, 0));

            Vector3 posRight = transform.position + (-i * right.transform.right);
            Vector3 posLeft = transform.position + (-i * (-left.transform.right));

            right.transform.position = posRight;
            left.transform.position = posLeft;

            right.transform.up = (right.transform.position - earth.transform.position);
            left.transform.up = (left.transform.position - earth.transform.position);



        }
    }
}
