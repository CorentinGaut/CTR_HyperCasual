using UnityEngine;
using System.Collections;

public class csDestroyEffect : MonoBehaviour {
    private float count = 0;
	void Update () {
        count += Time.deltaTime;
        if (count >= 0.9f)
        {
            Destroy(gameObject);
        }
    }
}
