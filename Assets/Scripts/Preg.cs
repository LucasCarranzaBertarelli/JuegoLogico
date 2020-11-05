using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class Preg : MonoBehaviour
{
    public GameObject Pregunta1, Pregunta2, Pregunta3, Pregunta4, Inicio, Options,Dibujo;
    public static float tiempo;

    //Array que contiene los grafcos de las preguntas
    GameObject[] TodasLasPreguntas;

    // Start is called before the first frame update
    void Start()
    {

        TodasLasPreguntas = new GameObject[4];
        TodasLasPreguntas[0] = Pregunta1;
        TodasLasPreguntas[1] = Pregunta2;
        TodasLasPreguntas[2] = Pregunta3;
        TodasLasPreguntas[3] = Pregunta4;

        //apaga todas las Preguntas
        /* for (int i = Juego.nivel; i < 4; i++)
         {
             TodasLasPreguntas[i].GetComponent<SpriteRenderer>().forceRenderingOff = true;
             Options.GetComponent<SpriteRenderer>().forceRenderingOff = true;
         }*/
    }

    // Update is called once per frame
    void Update()
    {

        //apaga todas las Preguntas
        if (Juego.nivel > -1)
        {
            for (int i = Juego.nivel; i < 4; i++)
            {
                TodasLasPreguntas[i].GetComponent<SpriteRenderer>().forceRenderingOff = true;
                Options.GetComponent<SpriteRenderer>().forceRenderingOff = true;
            }
        }


        //apaga inicio y prende la advertencia de 90% al usuario
        if (Juego.nivel == 1)
        {
            Dibujo.GetComponent<SpriteRenderer>().forceRenderingOff = false;
            Inicio.GetComponent<SpriteRenderer>().forceRenderingOff = true;
            tiempo += Time.deltaTime * 1;
        }

        //apaga inicio y prende el nivel 1
        if (Juego.nivel == 1 && tiempo > 5)
        {
            Dibujo.GetComponent<SpriteRenderer>().forceRenderingOff = true;
            TodasLasPreguntas[0].GetComponent<SpriteRenderer>().forceRenderingOff = false;
        }


        if (Juego.nivel == -1)
        {
            Options.GetComponent<SpriteRenderer>().forceRenderingOff = false;
            Inicio.GetComponent<SpriteRenderer>().forceRenderingOff = true;
        }
        //esto prende el inicio (nivel 0)
        if (Juego.nivel == 0)
        {
            Inicio.GetComponent<SpriteRenderer>().forceRenderingOff = false;
        }




        if (Juego.pregCorrecta == true)
        {
            //transforma la Respuesta de Eleccion en 0, esto para que no se apriete solo la respuesta del el proximo nivel
            //Eleccion.Respuesta = 0;
            Eleccion.respuestaEliminada[0] = 0;
            Eleccion.respuestaEliminada[1] = 0;
            Eleccion.respuestaEliminada[2] = 0;
            Eleccion.respuestaEliminada[3] = 0;


            //Apaga los graficos del nivel que pase
            TodasLasPreguntas[Juego.nivel - 2].GetComponent<SpriteRenderer>().forceRenderingOff = true;


            //Prende los graficos del nivel en que estoy
            if (Juego.nivel <= 4)
            {
                TodasLasPreguntas[Juego.nivel - 1].GetComponent<SpriteRenderer>().forceRenderingOff = false;

            }
            Juego.pregCorrecta = false;
        }
    }
}