using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Objetos : MonoBehaviour
{
    //public GameObject sign;
    public GameObject TextObj;
    public GameObject IconBot;
    //public GameObject IconMoc;
    public GameObject Obj;
    bool canvasact = false;


    //public Text text1;

    // Start is called before the first frame update
    void Update()
    {
        if(canvasact == true){
                if(Input.GetKeyDown(KeyCode.X)){
                print("hello");
                Destroy(Obj);    
                Destroy(TextObj);
                Destroy(gameObject);
                IconBot.SetActive(true);
        }}
    }
    // Update is called once per frame
        private void OnTriggerEnter(Collider other)
    {

        if(other.tag == "Flechas"){
        // Add scene info to the same scene SceneManager.LoadScene("Planta1", LoadSceneMode.Additive);
        
        //SceneManager.LoadScene("Loading screen");
        //sign.SetActive(true);
        TextObj.SetActive(true);
        canvasact = true;
        
        }
    }

    private void OnTriggerExit(Collider others)
    {
        if(others.tag == "Flechas"){
        //sign.SetActive(false);
        TextObj.SetActive(false);
        canvasact = false;
        }
    }
}
