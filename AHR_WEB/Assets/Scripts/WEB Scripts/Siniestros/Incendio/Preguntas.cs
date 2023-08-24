using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Preguntas : MonoBehaviour
{
    public GameObject cuestionario;
    public GameObject respuesta;
    public GameObject notif;
    public bool answer = false;
    public Text respuestatext;
    private float elapsed = 0f;
    private float elapsed1 = 0f;


    // Update is called once per frame
    void Update()
    {
        //timer
        for (float f = 5f; f >= 0; f -= 0.1f) {
    }
        //texto
        if(Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Alpha3)){
        answer=false;
        cuestionario.SetActive(false);
        respuesta.SetActive(true);
        respuestatext.text = "Respuesta incorrecta, intenta de nuevo.";
        }

        if(Input.GetKeyDown(KeyCode.Alpha4)){
        answer=true;
        cuestionario.SetActive(false);
        respuesta.SetActive(true);
        respuestatext.text = "Respuesta correcta! Por favor continua con la simulacion y selecciona el tipo correcto de extintor.";
        }

        //resultados
        if(answer==true){
            elapsed1 += Time.deltaTime;
            if (elapsed1 >= 4f) {
                elapsed1 = elapsed1 % 5f;
                gameObject.SetActive(false);
                respuesta.SetActive(false);
                notif.SetActive(true);
            }
        }
        else if(answer==false){
        elapsed += Time.deltaTime;
            if (elapsed >= 2f) {
                elapsed = elapsed % 5f;
                cuestionario.SetActive(true);
                respuesta.SetActive(false);
            }
        }
    }
}
