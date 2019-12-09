using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    public GameObject effectPrefab;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.gameObject.transform.localScale = new Vector3(1, 1, 2);
            Instantiate(effectPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }

    }
}
