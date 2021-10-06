using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public Material playerMaterial;


    public void ColorRed()
    {

        playerMaterial.SetColor("_Color", Color.red);
       
    }

    public void ColorBlue()
    {
        playerMaterial.SetColor("_Color", Color.blue);
    }

    public void ColorMagenta()
    {
        playerMaterial.SetColor("_Color", Color.magenta);
    }

    public void ColorYellow()
    {
        playerMaterial.SetColor("_Color", Color.yellow);
    }

    public void ColorGreen()
    {
        playerMaterial.SetColor("_Color", Color.green);
    }


}

