using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SillonScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject sillon;
    public GameObject earth;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject sill = Instantiate(sillon, this.transform.position, this.transform.rotation);
        sill.GetComponent<GeneratePlants>().earth = earth;
    }
}
