using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider2 : MonoBehaviour
{
    public GameObject NotifInc;
    public GameObject fuego;
    public GameObject alarma;
    public GameObject extAnim;

    private float elapsed = 0f;
    private float elapsed1 = 0f;
    private bool timeron = false;
    private bool canfinbool = false;
    public GameObject canfin;
    


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
                alarma.SetActive(false);
                canfinbool = true;
            }
        }
        if(canfinbool == true){
        elapsed += Time.deltaTime;
            if (elapsed >= 2f) {
                elapsed = elapsed % 5f;
                canfin.SetActive(true);
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
