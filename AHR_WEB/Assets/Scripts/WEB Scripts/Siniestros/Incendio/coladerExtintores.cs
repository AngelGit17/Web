using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class coladerExtintores : MonoBehaviour
{
    //public GameObject sign;
    public GameObject imagen1;
    //public GameObject sign;
    public GameObject TextObj;
    public GameObject IconBot;

    public GameObject icon1;
    public GameObject icon2;
    public GameObject icon3;

    //public GameObject IconMoc;
    public GameObject Obj;
    bool canvasact = false;

    public bool extintorselect = false;


    //public Text text1;
    void Start(){
        extintorselect = false;
    }
    // Start is called before the first frame update
    void Update()
    {
        if(canvasact == true){
                if(Input.GetKeyDown(KeyCode.X)){
                Destroy(Obj);    
                //Destroy(TextObj);
                
                TextObj.SetActive(false);
                IconBot.SetActive(true);
                imagen1.SetActive(false);
        }}

        if(icon1.activeSelf || icon2.activeSelf || icon3.activeSelf){
            extintorselect =true;
        }
    }
    // Update is called once per frame
        private void OnTriggerEnter(Collider other)
    {
        if(extintorselect == false){
        if(other.tag == "Flechas"){
        // Add scene info to the same scene SceneManager.LoadScene("Planta1", LoadSceneMode.Additive);
        
        //SceneManager.LoadScene("Loading screen");
        //sign.SetActive(true);
        TextObj.SetActive(true);
        imagen1.SetActive(true);
        canvasact = true;
        }
        }
    }

    private void OnTriggerExit(Collider others)
    {
        
        if(others.tag == "Flechas"){
        //sign.SetActive(false);
        TextObj.SetActive(false);        
        imagen1.SetActive(false);
        canvasact = false;
        }
    }


}
