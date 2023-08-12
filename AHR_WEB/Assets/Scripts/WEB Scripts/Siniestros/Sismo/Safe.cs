using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Safe : MonoBehaviour
{
    //public GameObject sign;
    public GameObject safezone;

    //public Text text1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
        private void OnTriggerEnter(Collider other)
    {

        if(other.tag == "Flechas"){
        // Add scene info to the same scene SceneManager.LoadScene("Planta1", LoadSceneMode.Additive);
        
        //SceneManager.LoadScene("Loading screen");
        //sign.SetActive(true);
        safezone.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider others)
    {
        if(others.tag == "Flechas"){
        //sign.SetActive(false);
        safezone.SetActive(false);

        }
    }
}
