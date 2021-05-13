using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseRotate : MonoBehaviour
{
    //makes gameObj. with this script follow the mouse
    Vector3 diff;
    Camera tgtCam;
    // Update is called once per frame
    private void Awake() {
        //get the main camera
        tgtCam = Camera.main;
    }
    private void FixedUpdate() {
        //get mouse position and convert it to world position, minus self position
        //make the transform.up as the result
        diff = tgtCam.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        transform.up = diff;
    }
}
