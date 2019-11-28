using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthGravity : MonoBehaviour
{
    // Singleton
    public static EarthGravity instance;
    public float gravity = -10.0f;
    public SphereCollider collider;

    void Awake()
    {
        instance = this;
        collider.GetComponent<SphereCollider>();    
    }

    //force sur les objets pour creer l'effet gravité
    public void GravityForce(Rigidbody obj)
    {
        Vector3 gravityV = (obj.position - transform.position).normalized;
        obj.AddForce(gravityV * gravity);
        RotateBody(obj);
    }

    //
    public void SurfacePlanet(Rigidbody obj)
    {
        obj.MovePosition((obj.position - transform.position).normalized * (transform.localScale.x * collider.radius));

        RotateBody(obj);
    }

    void RotateBody(Rigidbody body)
    {
        Vector3 gravityUp = (body.position - transform.position).normalized;
        Quaternion targetRotation = Quaternion.FromToRotation(body.transform.up, gravityUp) * body.rotation;
        body.MoveRotation(Quaternion.Slerp(body.rotation, targetRotation, 50f * Time.deltaTime));
    }
}
