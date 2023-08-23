using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCounerIn : MonoBehaviour
{
    public GameObject Ima1;
    public GameObject Ima2;
    public GameObject Ima3;
    public GameObject Ima4;
    public GameObject Ima5;
    public GameObject canvasgfin;

    // Start is called before the first frame update
    void Update()
    {  
    if(!Ima1.activeSelf && !Ima2.activeSelf && !Ima3.activeSelf && !Ima4.activeSelf && !Ima5.activeSelf)
    {
        canvasgfin.SetActive(true);
    }
    
    }
}