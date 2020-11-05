using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiempo : MonoBehaviour
{
    public static float tiempoRespuesta = 30;

    public GameObject Credito;
    public static int vidas=10;


    // Update is called once per frame
    void Update()
    {


        tiempoRespuesta -= Time.deltaTime;
        GetComponent<TextMesh>().text = "Tiempo: " + ((int)tiempoRespuesta).ToString();
        if ((int)tiempoRespuesta == 0) tiempoRespuesta = 30;
        if (Juego.respuesta != 0) tiempoRespuesta = 29;

        //hace que no empiece el tiempo hasta que salga del inicio
        if (Juego.nivel < 1||Preg.tiempo<5)
        {
            GetComponent<TextMesh>().text = "";
            tiempoRespuesta = 29;
        }
        if (Juego.nivel > 0)
        {
            Credito.GetComponent<TextMesh>().text = "Credits: " + vidas;

        }



    }
}
