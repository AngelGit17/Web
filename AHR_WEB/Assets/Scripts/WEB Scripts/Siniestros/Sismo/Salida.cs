using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Salida : MonoBehaviour
{
    //public GameObject sign;
    public SismoTimers Time;
    public GameObject ImaBot;
    public GameObject ImaMoc;
    public GameObject flechaslight;
    public GameObject NotifText;


    //public Text text1;

    // Start is called before the first frame update
    void Start()
    {
        Time = FindObjectOfType<SismoTimers>();
    }
    void Update()
    {
        if(ImaBot.activeSelf && ImaMoc.activeSelf){
            flechaslight.SetActive(true);
            NotifText.SetActive(true);
            print(Time.Tiempo);
        }
    }

    // Update is called once per frame
}
