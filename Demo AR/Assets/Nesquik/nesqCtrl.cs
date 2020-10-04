using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nesqCtrl : MonoBehaviour
{
    public GameObject smallPieces;
    public Animator bigPiece;
    public detection dtctnScript;
    private void Start()
    {
        dtctnScript.targetDetected += ActivateSmallRigid;
        dtctnScript.targetLost += DeactivateSmallRig;
    }

    private void DeactivateSmallRig()
    {
        Rigidbody[] rbs = smallPieces.GetComponentsInChildren<Rigidbody>();
        foreach (var rb in rbs)
            rb.isKinematic = true;
    }

    private void ActivateSmallRigid()
    {
        Rigidbody[] rbs = smallPieces.GetComponentsInChildren<Rigidbody>();
        foreach (var rb in rbs)
            rb.isKinematic = false;
        //dtctnScript.targetDetected -= ActivateSmallRigid;
        StartCoroutine(PlayBigAni());
    }

    private IEnumerator PlayBigAni()
    {
        yield return new WaitForSeconds(2f);
        bigPiece.Play("open");
    }
}
