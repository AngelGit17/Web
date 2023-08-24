using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firetype : MonoBehaviour
{
    
    public GameObject Fire1;
    public GameObject Fire2;

    public GameObject Ext1;
    public GameObject Ext2;
    public GameObject Ext3;
    public GameObject coll;
    public GameObject coll2;
    public bool inccon = false;
    public bool inccon1 = false;


    // Update is called once per frame
    void Update()
    {
        if(Fire1.activeSelf)
        {
            if(Ext2.activeSelf || Ext3.activeSelf){
                inccon = true;
                coll.SetActive(true);
            }
            else {
                inccon = false;
            }
        }
        if(Fire2.activeSelf)
        {
            if(Ext1.activeSelf || Ext2.activeSelf){
                inccon1 = true;
                coll2.SetActive(true);
            }
            else {
                inccon1 = false;
            }
        }
    }
}
