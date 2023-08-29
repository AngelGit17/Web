using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Safe : MonoBehaviour
{
    //public GameObject sign;
    public GameObject safezone;
    public float Tiempo = 5;
    public Text timerText;
    public GameObject texto;
    public GameObject textoNum;
    bool TimerOn = false;
    bool Timerfin = false;
    public GameObject sonido;
    public GameObject Polvo;
    public GameObject Anuncio;
    public bool desplegado = false;


    //public Text text1;

    // Start is called before the first frame update
    void Start()
    {

    }
    void Update(){

        timerText.text = Tiempo.ToString() +"   "+"SEG.";

        if (TimerOn==true && Tiempo>0)
        {
            Tiempo -= Time.deltaTime;
        }
        else if (TimerOn==true && Tiempo <= 0)
        {
            Tiempo = 0;
            Timerfin = true;
        }
            
        
        if(TimerOn==true && Tiempo==0)
        {
            Polvo.SetActive(false);
            Anuncio.SetActive(true);
            desplegado = true;
        }
        

        }
    // Update is called once per frame
        private void OnTriggerEnter(Collider other)
    {

        if(other.tag == "Flechas"){
        // Add scene info to the same scene SceneManager.LoadScene("Planta1", LoadSceneMode.Additive);
        
        //SceneManager.LoadScene("Loading screen");
        //sign.SetActive(true);
        Polvo.SetActive(true);
        safezone.SetActive(true);
        texto.SetActive(true);
        textoNum.SetActive(true);
        sonido.SetActive(false);
        TimerOn = true;
        
        }
    }

    private void OnTriggerExit(Collider others)
    {
        if(others.tag == "Flechas"){
        //sign.SetActive(false);
        safezone.SetActive(false);
        texto.SetActive(false);
        textoNum.SetActive(false);
        TimerOn = false;
        
        if(!Timerfin){
            Tiempo = 5;
            }
        }
    }
}
