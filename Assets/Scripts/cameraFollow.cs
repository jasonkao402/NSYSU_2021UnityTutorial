using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform tgt;
    public float lerpAmt;
    public void setTarget(Transform _tgt)
    {
        tgt = _tgt;
    }
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, tgt.position, lerpAmt);
    }
}
