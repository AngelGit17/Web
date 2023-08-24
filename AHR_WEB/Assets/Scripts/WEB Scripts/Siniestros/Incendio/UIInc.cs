using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInc : MonoBehaviour
{
    public GameObject NotifInc;
    public GameObject NotifInc2;
    public GameObject Colliderseg;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
        private void OnTriggerEnter(Collider other)
    {

        if(other.tag == "Flechas"){
                
            NotifInc.SetActive(true);
    }
    }
}
