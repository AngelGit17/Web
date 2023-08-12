using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ChangeScene : MonoBehaviour
{
    //public GameObject sign;
    public GameObject canvas;
    public GameObject piso;
    public float Counter = 0.8f;
    public bool TimerOn = false;

    //public Text text1;

    // Start is called before the first frame update
    void Start()
    {
        //sign.SetActive(false);
        canvas.SetActive(false);
        piso.SetActive(false);

    }

    // Update is called once per frame
        private void OnTriggerEnter(Collider other)
    {

        if(other.tag == "TriggerUp"){
        // Add scene info to the same scene SceneManager.LoadScene("Planta1", LoadSceneMode.Additive);
        
        //SceneManager.LoadScene("Loading screen");
        //sign.SetActive(true);
        piso.SetActive(true);

        print("hello");
        }
        if(other.tag == "Entrada"){
        // Add scene info to the same scene SceneManager.LoadScene("Planta1", LoadSceneMode.Additive);
        
        SceneManager.LoadScene("Entrada");
        //print("hiEntrada");
        }
        if(other.tag == "Comedor"){
        // Add scene info to the same scene SceneManager.LoadScene("Planta1", LoadSceneMode.Additive);
        
        SceneManager.LoadScene("Comedor");
        //print("hiComedor");
        }

        if(other.tag == "Planta1"){
        // Add scene info to the same scene SceneManager.LoadScene("Planta1", LoadSceneMode.Additive);
        
        SceneManager.LoadScene("Planta1");
        //print("hiPlanta1");
        }
        
        if(other.tag == "Juntas"){
        // Add scene info to the same scene SceneManager.LoadScene("Planta1", LoadSceneMode.Additive);
        
        SceneManager.LoadScene("Sala de Juntas");
        //print("hiJuntas");
        }
    }
    private void OnTriggerExit(Collider others)
    {
        if(others.tag == "TriggerUp"){
        //sign.SetActive(false);
        piso.SetActive(false);
        }
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
        canvas.SetActive(true);
        TimerOn = true;
        }

        if(TimerOn){
            if (Counter > 0)
            {
                Counter -= Time.deltaTime;
            }
        //Counter = 1;
        //print(Counter);
        }else if (Counter <=0) {
            TimerOn = false;
        }

        
        if(Input.GetKeyDown(KeyCode.Space) && Counter <= 0){
        canvas.SetActive(false);  
        Counter = 0.8f;
        //Counter = 0;
        //print(Counter);
        }

        
    }
}
