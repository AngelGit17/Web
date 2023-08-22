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
    public GameObject ImaVol;
    public GameObject ImaMoc;
    public GameObject flechaslight;
    public GameObject NotifText;
    public Text timerfinal;
    private float timetext;


    //public Text text1;

    // Start is called before the first frame update
    void Start()
    {
        Time = FindObjectOfType<SismoTimers>();
    }
    void Update()
    {
        if(ImaBot.activeSelf && ImaMoc.activeSelf && ImaVol.activeSelf){
            flechaslight.SetActive(true);
            NotifText.SetActive(true);
        }

        timerfinal.text = Time.Tiempo.ToString() +" seg.";
    }

    // Update is called once per frame
}
