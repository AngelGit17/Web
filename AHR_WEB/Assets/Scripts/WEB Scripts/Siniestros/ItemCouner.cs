using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCouner : MonoBehaviour
{
    public GameObject Ima1;
    public GameObject Ima2;
    public GameObject Ima3;
    public GameObject Ima4;
    public GameObject Ima5;
    public GameObject Ima6;
    public GameObject Ima7;
    public GameObject Ima8;
    public GameObject Ima9;
    public GameObject Ima10;
    public GameObject Ima11;
    public GameObject canvasgfin;

    // Start is called before the first frame update
    void Update()
    {  
    if(!Ima1.activeSelf && !Ima2.activeSelf && !Ima3.activeSelf && !Ima4.activeSelf && !Ima5.activeSelf && !Ima6.activeSelf && !Ima7.activeSelf && !Ima8.activeSelf && !Ima9.activeSelf && !Ima10.activeSelf && !Ima11.activeSelf)
    {
        canvasgfin.SetActive(true);
    }
    
    }
}