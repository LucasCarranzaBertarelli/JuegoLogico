using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;


    public static class Eleccion
    {
    public static int j = 0;
    public static int Respuesta = 0;

   // static int [] respuestaEliminada;


    public static int Election()
        {
       // respuestaEliminada = new int[3] { 0, 0, 0 };

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
            Respuesta= 1;
        if (Input.GetMouseButtonDown(0) && positionX > Screen.width / 2 && positionY < Screen.height * .4 && (Circulo.z > 90 && Circulo.z < 180))
            Respuesta= 2;
        if (Input.GetMouseButtonDown(0) && positionX > Screen.width / 2 && positionY < Screen.height * .4 && (Circulo.z > -180 && Circulo.z < -90))
            Respuesta= 3;
        if (Input.GetMouseButtonDown(0) && positionX > Screen.width / 2 && positionY < Screen.height * .4 && (Circulo.z < 0 && Circulo.z > -90)) 
            Respuesta= 4;



        //Elimina una opcion cuando uno pide ayuda
        if ((int)Tiempo.tiempoRespuesta==30||Input.GetKeyDown("h") || Input.GetMouseButtonDown(0) && positionX > Screen.width / 2 && positionY < Screen.height*.55 &&positionY>Screen.height*.4)
            {

            for (int i = 0; i < 4; i++)
            {
                if (Juego.nivel == Juego.arrayLevel[i].nivel)
                    {
                        if (j == 0) Respuesta = Juego.arrayLevel[i].eliminar1;
                        if (j == 1) Respuesta = Juego.arrayLevel[i].eliminar2;
                        if (j == 2) Respuesta = Juego.arrayLevel[i].eliminar3;
                    j++;

                    }
            }
            }
       
       /* for(int i = 0; i < 3; i++)
        {
            if (respuestaEliminada[i] != 0)
            respuestaEliminada[i] = Respuesta;
no funciona que es lo que pasas que apasa
        }*/


        return Respuesta;
        }
    }