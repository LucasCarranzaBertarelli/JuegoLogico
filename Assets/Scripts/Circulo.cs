
using UnityEngine;

public class Circulo : MonoBehaviour
{
    public static float z;
    public static float zViejo = 0;
    static double xViejo = 175;
    static double yViejo = 389;
    public GameObject help;


    // Update is called once per frame
    public void Update()
    {

        double x = Input.mousePosition.x;
        double y = Input.mousePosition.y;
        float control = z;

        //apaga el circulo durante el inicio
        if (Juego.nivel < 1)
        {
            GetComponent<SpriteRenderer>().forceRenderingOff = true;
            help.GetComponent<SpriteRenderer>().forceRenderingOff = true;

        }
        else
        {
            GetComponent<SpriteRenderer>().forceRenderingOff = false;
            help.GetComponent<SpriteRenderer>().forceRenderingOff = false;
        }



        //gira la rueda en funcion del mouse
        if (x < Screen.width / 2 && y < Screen.height * .4 && y > Screen.height * .2)
        {
            if (x > xViejo && y < 389 || x < xViejo && y > 389)
                z++;
            if (x < xViejo && y < 389 || x > xViejo && y > 389)
                z--;


            if (y > yViejo && x > 175 || y < yViejo && x < 175)
                z++;
            if (y < yViejo && x > 175 || y > yViejo && x < 175)
                z--;

            if (zViejo < z)
            {
                z += Time.deltaTime * 60;
            }
            if (zViejo > z)
                z -= Time.deltaTime * 60;

            transform.rotation = Quaternion.Euler(0, 0, z);

            if (z > 360) z = 0;
            if (z < -360) z = 0;

            // sonido al girar rueda

            if (!Juego.inicio && zViejo != z && !GetComponent<AudioSource>().isPlaying) GetComponent<AudioSource>().Play();

            xViejo = x;
            yViejo = y;
            zViejo = z;



        }
    }
}
