using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlants : MonoBehaviour
{
    public GameObject particules;
    private void OnTriggerEnter(Collider other)
    {
        GenerateBle g = FindObjectOfType<GenerateBle>();
        g.nbDetruis++;
        
        GameObject part = Instantiate(particules,gameObject.transform.position, other.transform.rotation);
        Destroy(this.gameObject);
    }
}
