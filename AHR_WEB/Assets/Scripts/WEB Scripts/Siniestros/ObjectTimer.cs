using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTimer : MonoBehaviour
{
    public float elapsed = 0f;
    
    void Update(){
        for (float f = 2f; f >= 0; f -= 0.1f) {
    }
    }

    void FixedUpdate()
    {
        elapsed += Time.deltaTime;
     if (elapsed >= 10f) {
         elapsed = elapsed % 10f;
			Destroy(gameObject);
     }
    }
}
