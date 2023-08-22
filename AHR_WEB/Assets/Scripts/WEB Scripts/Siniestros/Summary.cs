using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class Summary : MonoBehaviour
{
    bool canvas = false;
    public GameObject ImaBot;
    public GameObject ImaMoc;
    public GameObject ImaVol;
    public GameObject ImaBotS;
    public GameObject ImaMocS;
    public GameObject ImaVolS;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ImaBot.activeSelf){
            ImaBotS.SetActive(true);
        }
        if(ImaMoc.activeSelf){
            ImaMocS.SetActive(true);
        }
        if(ImaVol.activeSelf){
            ImaVolS.SetActive(true);
        }

        
        if(Input.GetKeyDown(KeyCode.X)){
        SceneManager.LoadScene("Entrada");
        }
        if(Input.GetKeyDown(KeyCode.R)){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
