using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colaCtrl : MonoBehaviour
{
    public Animator cola;
    public cola_detection dtcnScript;

    void Start()
    {
        dtcnScript.onTargetFound += StartAnimation;
        dtcnScript.onTargetLost += StopAnimation;
            
    }

    private void StartAnimation()
    {
        cola.Play("drive");
        cola.StartPlayback();
    }

    private void StopAnimation()
    {
        cola.StopPlayback();
    }



}
