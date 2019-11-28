using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityObject : MonoBehaviour
{

    private EarthGravity gravity;
    private Rigidbody rb;

    public bool OnSurface = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        gravity = EarthGravity.instance;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (OnSurface)
        {
            gravity.SurfacePlanet(rb);
        }
        else
        {
            gravity.GravityForce(rb);
        }
    }
}
