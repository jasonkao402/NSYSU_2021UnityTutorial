using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkCol : MonoBehaviour
{
    // Start is called before the first frame update
    Animator ani;
    void Start()
    {
        ani = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("PlayerItem"))
        {
            Debug.Log(other.name+" hit me!");
            if(ani != null)
            {
                ani.SetTrigger("isHurt");
            }
        }
    }
}