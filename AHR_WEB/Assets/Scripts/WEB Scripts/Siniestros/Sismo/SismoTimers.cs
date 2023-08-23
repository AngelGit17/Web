using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SismoTimers : MonoBehaviour
{
    //primer parte


    //Timer 5seg
    public Safe desp;

    public float Tiempo = 54;
    public Text timerText;
    
    //Comp Final
    public GameObject ImaBot;
    public GameObject ImaVol;
    public GameObject ImaMoc;
    public GameObject Final;

    public GameObject finalCanvas;
    public float marcador;
    public bool play = true;

void Start(){

    desp = FindObjectOfType<Safe>();
    play = true;
}
    // Update is called once per frame
    void Update()
    {

        if(play){
        if (Tiempo>0)
        {
            Tiempo -= Time.deltaTime;
        }
        else 
        {
            Tiempo = 0;
        }
            timerText.text = Tiempo.ToString() +"   "+"SEG.";
        if(Tiempo==0 && desp.desplegado == false)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        }
        
        if(ImaBot.activeSelf && ImaMoc.activeSelf && ImaVol.activeSelf && Final.activeSelf){
            
            play = false;
        }    
    }


    void Marker(){
        if(finalCanvas.activeSelf){
            marcador = Tiempo;
        }
    }
    
}
