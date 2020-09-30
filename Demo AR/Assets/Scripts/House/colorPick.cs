using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorPick : MonoBehaviour
{
    public List<GameObject> colorWheel = new List<GameObject>();
    public Material wallMat;


    public void openColors()
    {
        foreach (GameObject go in colorWheel)
            go.SetActive(true);
    }

    public void closeColor()
    {
        foreach (GameObject go in colorWheel)
            go.SetActive(false);
    }

    public void pick_1()
    {
        wallMat.color = new Color(0.9811321f, 0.9751353f, 0.7080812f);
        closeColor();
    }
    public void pick_2()
    {
        wallMat.color = new Color(0.8584906f, 0.8584906f, 0.8584906f);
        closeColor();
    }
    public void pick_3()
    {
        wallMat.color = new Color(0.7595674f, 0.9528302f, 0.9387388f);
        closeColor();
    }
}
