using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SismoTimers : MonoBehaviour
{
    public float Tiempo = 54;
    public Text timerText;
void Start(){
}
    // Update is called once per frame
    void Update()
    {
        if (Tiempo>0)
        {
            Tiempo -= Time.deltaTime;
        }
        else 
        {
            Tiempo = 0;
        }
            timerText.text = Tiempo.ToString() +"   "+"SEG.";
        if(Tiempo==0)
        {
            print("Prueba fallida");
        }
    }
        
}
