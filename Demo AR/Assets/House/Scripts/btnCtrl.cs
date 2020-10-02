using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnCtrl : MonoBehaviour
{
    public GameObject texts;
    public GameObject furniture;
    public GameObject doors;

    private bool isTextOn = true;
    private bool isFurOn = true;
    private bool isDoorsOn = true;
    

    public void textClicked()
    {
        if (isTextOn) {
            texts.SetActive(false);
            isTextOn = !isTextOn;
        }
        else
        {
            texts.SetActive(true);
            isTextOn = !isTextOn;
        }
            
    }

    public void furnitureCliked()
    {
        if (isFurOn)
        {
            furniture.SetActive(false);
            isFurOn = !isFurOn;
        }
        else
        {
            furniture.SetActive(true);
            isFurOn = !isFurOn;
        }
    }

    public void doorsClicked()
    {
        if (isDoorsOn)
        {
            doors.SetActive(false);
            isDoorsOn = !isDoorsOn;
        }
        else
        {
            doors.SetActive(true);
            isDoorsOn = !isDoorsOn;
        }
    }
}
