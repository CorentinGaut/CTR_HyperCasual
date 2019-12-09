using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlants : MonoBehaviour
{

    void Start()
    {
    }
    private void OnTriggerEnter(Collider other)
    {
        GenerateBle g = FindObjectOfType<GenerateBle>();
        g.nbDetruis++;
        Destroy(this.gameObject);
    }
}
