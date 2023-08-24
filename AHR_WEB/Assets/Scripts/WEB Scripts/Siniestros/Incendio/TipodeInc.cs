using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipodeInc : MonoBehaviour
{
    public GameObject Inc1;
    public GameObject Inc2;
    private float elapsed = 0f;
    int value;
    // Start is called before the first frame update

    // Update is called once per frame
    void Start(){
        int randomNumber = Random.Range(1, 3);
        value = randomNumber;
        print(randomNumber);
    }
    void Update(){
        for (float f = 5f; f >= 0; f -= 0.1f) {
    }
    }
    void FixedUpdate()
    {
        if(value == 1){
        elapsed += Time.deltaTime;
     if (elapsed >= 5f) {
         elapsed = elapsed % 5f;
        Inc1.SetActive(true);
        print("Incendio 1");
     }}
     else if (value==2){
        Inc2.SetActive(true);
        print("Incendio 2");
     }
     }
}
