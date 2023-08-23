using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coladerUis : MonoBehaviour
{
    //public GameObject sign;
    public GameObject imagen1;
    //public int salida=0;


    //public Text text1;

    // Start is called before the first frame update
    // Start is called before the first frame update
   void Start()
    {

    }

    void Update()

    {
    //if(salida==1 && Input.GetKeyDown(KeyCode.Escape)){
		//SceneManager.LoadScene("Entrada");
        //}
    }
    // Update is called once per frame
        private void OnTriggerEnter(Collider other)
    {

        if(other.tag == "Flechas"){
        // Add scene info to the same scene SceneManager.LoadScene("Planta1", LoadSceneMode.Additive);
        
        //SceneManager.LoadScene("Loading screen");
        //sign.SetActive(true);
        imagen1.SetActive(false);
        //salida=1;
        }
    }
    //private void OnTriggerExit(Collider others)
    //{
        //if(others.tag == "Flechas"){
        //sign.SetActive(false);
        //imagen1.SetActive(false);
        //salida=0;
        //}
    //}

}