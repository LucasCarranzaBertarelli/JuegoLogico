using System.Collections;
using System.Collections.Generic;
//using System.Runtime.Remoting.Activation;
using UnityEngine;
using System.Security.Cryptography;
using System.Collections.Specialized;
using System.Diagnostics;
using Debug = UnityEngine.Debug;

public class Juego : MonoBehaviour
{
    public static int nivel = 0;
    public static int respuesta = 0;
    public int nivelRespuesta = 10;
    public static bool pregCorrecta;
    public static bool respCorrecta;

    public static Level[] arrayLevel;
    public static int eliminar;

    public static bool inicio = true;

    // Start is called before the first frame update
    void Start()
    {
        arrayLevel = new Level[4];
        var Level1 = new Level
        {
            nivel = 1,
            respuesta = 2,

        };
        var Level2 = new Level
        {
            nivel = 2,
            respuesta = 4,

        };
        var Level3 = new Level
        {
            nivel = 3,
            respuesta = 3,

        };
        var Level4 = new Level

        {
            nivel = 4,
            respuesta = 1,

        };
        arrayLevel[0] = Level1;
        arrayLevel[1] = Level2;
        arrayLevel[2] = Level3;
        arrayLevel[3] = Level4;

    }

    // Update is called once per frame
    void Update()
    {



        //elije la respuesta
        respuesta = Eleccion.Election();

        //chequea si la respuesta elejida es la correcta
        for (int i = 0; i < 4; i++)
        {
            if (nivel == arrayLevel[i].nivel)
                nivelRespuesta = arrayLevel[i].respuesta;
        }

        //si la respuesta es correcta se pasa de nivel sino elimina la imagen errada
        if (nivelRespuesta == respuesta)
        {
            nivel++;
            respCorrecta = true;
            pregCorrecta = true;
        }
        else
        {
            eliminar = respuesta;

        }

    }


}
