using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ColliderErr : MonoBehaviour
{
    public GameObject NotifErr;

    private float elapsed = 0f;
    private bool timeron = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
    for (float f = 5f; f >= 0; f -= 0.1f) {
            }
        if(timeron == true){
        elapsed += Time.deltaTime;
            if (elapsed >= 4f) {
                elapsed = elapsed % 5f;
    
                SceneManager.LoadScene("Incendio");
        }
    }}
    private void OnTriggerEnter(Collider other)
    {

        if(other.tag == "Flechas"){
                
            NotifErr.SetActive(true);
            timeron = true;
    }
    
    }
}
