
using UnityEngine;

public class Circulo : MonoBehaviour
{
    public static float z;
    static double xViejo = 175;
    static double yViejo = 389;
   
    // Update is called once per frame
   public void Update()
    {

        double x = Input.mousePosition.x;
        double y = Input.mousePosition.y;


        //gira la rueda en funcion del mouse
        if (x < Screen.width / 2 && y < Screen.height * .4 && y > Screen.height * .2)
        {
            if (x > xViejo && y < 389 || x < xViejo && y > 389)
                z = z + 2.5f;
            if (x < xViejo && y < 389 || x > xViejo && y > 389)
                z = z - 2.5f;


            if (y > yViejo && x > 175 || y < yViejo && x < 175)
                z = z + 2.5f;
            if (y < yViejo && x > 175 || y > yViejo && x < 175)
                z = z - 2.5f;

            transform.rotation = Quaternion.Euler(0, 0, z);

            if (z > 180) z = 0;
            if (z < -180) z = 0;

            xViejo = x;
            yViejo = y;
        }
        
    }
    
}
