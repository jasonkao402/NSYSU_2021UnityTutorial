using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animeCtrl_2 : MonoBehaviour
{
    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            animator.SetTrigger("isFire");
        }
    }
}
