using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider2 : MonoBehaviour
{
    public GameObject NotifInc;
    public GameObject fuego;
    public GameObject extAnim;
    private float elapsed = 0f;
    public bool timeron = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update(){
    for (float f = 5f; f >= 0; f -= 0.1f) {
            }
        
        if(Input.GetKeyDown(KeyCode.X)){
            extAnim.SetActive(true);
                timeron = true;
        }

        if(timeron == true){
        elapsed += Time.deltaTime;
            if (elapsed >= 4f) {
                elapsed = elapsed % 5f;
                fuego.SetActive(false);
            }
        }
    }
    // Update is called once per frame
        private void OnTriggerEnter(Collider other)
    {

        if(other.tag == "Flechas"){
                
            NotifInc.SetActive(true);
    }
    
    }
}
