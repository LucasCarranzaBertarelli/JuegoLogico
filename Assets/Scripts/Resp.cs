using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resp : MonoBehaviour
{

    public GameObject Resp1A, Resp1B, Resp1C, Resp1D, Resp2A, Resp2B, Resp2C, Resp2D;
    public GameObject Resp3A, Resp3B, Resp3C, Resp3D, Resp4A, Resp4B, Resp4C, Resp4D;

    //Array que contien los objetos(graficos) de las disferentes posibles respuestas
    GameObject[] TodasLasRespuestasA;
    GameObject[] TodasLasRespuestasB;
    GameObject[] TodasLasRespuestasC;
    GameObject[] TodasLasRespuestasD;


    void Start()
    {
        TodasLasRespuestasA = new GameObject[4];
        TodasLasRespuestasA[0] = Resp1A;
        TodasLasRespuestasA[1] = Resp2A;
        TodasLasRespuestasA[2] = Resp3A;
        TodasLasRespuestasA[3] = Resp4A;

        TodasLasRespuestasB = new GameObject[4];
        TodasLasRespuestasB[0] = Resp1B;
        TodasLasRespuestasB[1] = Resp2B;
        TodasLasRespuestasB[2] = Resp3B;
        TodasLasRespuestasB[3] = Resp4B;

        TodasLasRespuestasC = new GameObject[4];
        TodasLasRespuestasC[0] = Resp1C;
        TodasLasRespuestasC[1] = Resp2C;
        TodasLasRespuestasC[2] = Resp3C;
        TodasLasRespuestasC[3] = Resp4C;

        TodasLasRespuestasD = new GameObject[4];
        TodasLasRespuestasD[0] = Resp1D;
        TodasLasRespuestasD[1] = Resp2D;
        TodasLasRespuestasD[2] = Resp3D;
        TodasLasRespuestasD[3] = Resp4D;


        //Apaga los graficos posteriores al nivel en que estoy
        for (int i = Juego.nivel; i < 4; i++)
        {
            TodasLasRespuestasA[i].GetComponent<SpriteRenderer>().forceRenderingOff = true;
            TodasLasRespuestasB[i].GetComponent<SpriteRenderer>().forceRenderingOff = true;
            TodasLasRespuestasC[i].GetComponent<SpriteRenderer>().forceRenderingOff = true;
            TodasLasRespuestasD[i].GetComponent<SpriteRenderer>().forceRenderingOff = true;
        }

    }
    void Update()
    {

        if (Juego.nivel == 1&& Juego.inicio)
        {
            TodasLasRespuestasA[0].GetComponent<SpriteRenderer>().forceRenderingOff = false;
            TodasLasRespuestasB[0].GetComponent<SpriteRenderer>().forceRenderingOff = false;
            TodasLasRespuestasC[0].GetComponent<SpriteRenderer>().forceRenderingOff = false;
            TodasLasRespuestasD[0].GetComponent<SpriteRenderer>().forceRenderingOff = false;
            Juego.inicio = false;
        }



        //Apaga los graficos incorrectos que voy apretando
        if (Juego.eliminar == 1)
        {
            TodasLasRespuestasA[Juego.nivel - 1].GetComponent<SpriteRenderer>().forceRenderingOff = true;
        }
        if (Juego.eliminar == 2)
        {
            TodasLasRespuestasB[Juego.nivel - 1].GetComponent<SpriteRenderer>().forceRenderingOff = true;
        }
        if (Juego.eliminar == 3)
        {
            TodasLasRespuestasC[Juego.nivel - 1].GetComponent<SpriteRenderer>().forceRenderingOff = true;
        }
        if (Juego.eliminar == 4)
        {
            TodasLasRespuestasD[Juego.nivel - 1].GetComponent<SpriteRenderer>().forceRenderingOff = true;
        }


        if (Juego.respCorrecta == true)
        {
            //Apaga los graficos del nivel que pase
            TodasLasRespuestasA[Juego.nivel - 2].GetComponent<SpriteRenderer>().forceRenderingOff = true;
            TodasLasRespuestasB[Juego.nivel - 2].GetComponent<SpriteRenderer>().forceRenderingOff = true;
            TodasLasRespuestasC[Juego.nivel - 2].GetComponent<SpriteRenderer>().forceRenderingOff = true;
            TodasLasRespuestasD[Juego.nivel - 2].GetComponent<SpriteRenderer>().forceRenderingOff = true;



            //Prende los graficos del nivel en que estoy
            if (Juego.nivel <= 4)
            {
                TodasLasRespuestasA[Juego.nivel - 1].GetComponent<SpriteRenderer>().forceRenderingOff = false;
                TodasLasRespuestasB[Juego.nivel - 1].GetComponent<SpriteRenderer>().forceRenderingOff = false;
                TodasLasRespuestasC[Juego.nivel - 1].GetComponent<SpriteRenderer>().forceRenderingOff = false;
                TodasLasRespuestasD[Juego.nivel - 1].GetComponent<SpriteRenderer>().forceRenderingOff = false;
            }

            Juego.respCorrecta = false;
        }

    }
}
