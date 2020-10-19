using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using System;



public static class Eleccion
    {
    public static int j = 0;
    public static int Respuesta = 0;
    static bool funciono = false;
    public static int [] respuestaEliminada=new int[4] { 0, 0, 0,0 };





    public static int Election()
    {
        Respuesta = 0;
        var positionX = Input.mousePosition.x;
        var positionY = Input.mousePosition.y;
        /*
                    //elige una opcion con los numero las letras o el mouse
                    if (Input.GetKeyDown("1")||Input.GetKeyDown("a")|| Input.GetMouseButtonDown(0)&& positionX>Screen.width/2 && positionX<Screen.width-Screen.width/4&&positionY>Screen.height*.75)
                    Respuesta= 1;
                    if (Input.GetKeyDown("2")||Input.GetKeyDown("b") || Input.GetMouseButtonDown(0) && positionX > Screen.width - Screen.width / 4&& positionX < Screen.width && positionY > Screen.height*.75)
                    Respuesta = 2;
                    if (Input.GetKeyDown("3")|| Input.GetKeyDown("c") || Input.GetMouseButtonDown(0) && positionX > Screen.width / 2 && positionX < Screen.width - Screen.width / 4 && positionY<Screen.height*.75&&positionY>Screen.height*.63)
                    Respuesta= 3;
                    if (Input.GetKeyDown("4")|| Input.GetKeyDown("d") || Input.GetMouseButtonDown(0) && positionX > Screen.width - Screen.width / 4 && positionX < Screen.width && positionY < Screen.height * .75 && positionY > Screen.height*.63)
                    Respuesta= 4;*/


        //elige una opcion de acuerdo al angulo del circulo
        if (Input.GetMouseButtonDown(0) && positionX > Screen.width / 2 && positionY < Screen.height * .4 && (Circulo.z > 0 && Circulo.z < 90))
            Respuesta = 1;
        if (Input.GetMouseButtonDown(0) && positionX > Screen.width / 2 && positionY < Screen.height * .4 && (Circulo.z > 90 && Circulo.z < 180))
            Respuesta = 2;
        if (Input.GetMouseButtonDown(0) && positionX > Screen.width / 2 && positionY < Screen.height * .4 && (Circulo.z > -180 && Circulo.z < -90))
            Respuesta = 3;
        if (Input.GetMouseButtonDown(0) && positionX > Screen.width / 2 && positionY < Screen.height * .4 && (Circulo.z < 0 && Circulo.z > -90))
            Respuesta = 4;



        //Elimina una opcion cuando uno pide ayuda chequeando que no se haya elegido esa respuesta antes.
        if ((int)Tiempo.tiempoRespuesta == 30 || Input.GetKeyDown("h") || Input.GetMouseButtonDown(0) && positionX > Screen.width / 2 && positionY < Screen.height * .55 && positionY > Screen.height * .4)
        {
            for (int i = 0; i < 4; i++)
            {
                if (Juego.nivel == Juego.arrayLevel[i].nivel)
                {
                   funciono = false;
                    while (funciono == false)
                    {
                        System.Random rnd = new System.Random();
                        int respuestaErronea = rnd.Next(1, 5);

                        for (j = 0; j <= 3; j++)
                        {
                            if (respuestaErronea == respuestaEliminada[j])
                                break;

                            if (respuestaErronea != Juego.arrayLevel[i].respuesta&& respuestaEliminada[j]==0)
                            {
                                Respuesta = respuestaErronea;
                                funciono = true;
                                break;
                            }
                            if (j == 3)
                                funciono = true;
                        }
                    }
                }
            }
        }

        //RespuestaEliminada guarda cada respuesta que sea distinta a la anterior
        for (int i = 0; i < 4; i++)
        {
            if (Respuesta != 0 && respuestaEliminada[i] == 0 && respuestaEliminada[0] != Respuesta && respuestaEliminada[1] != Respuesta && respuestaEliminada[2] != Respuesta && respuestaEliminada[3] != Respuesta)
            {
                respuestaEliminada[i] = Respuesta;
                break;
            }
        }
        return Respuesta;
        }
    }