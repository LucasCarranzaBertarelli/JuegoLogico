using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiempo : MonoBehaviour
{
    public static float tiempoRespuesta=30;


    // Update is called once per frame
    void Update()
    {
       tiempoRespuesta -= Time.deltaTime;
        GetComponent<TextMesh>().text = "Tiempo: "+((int) tiempoRespuesta).ToString();
        if ((int)tiempoRespuesta == 0) tiempoRespuesta = 30;
        if (Juego.respuesta!=0) tiempoRespuesta = 29;

    }
}
