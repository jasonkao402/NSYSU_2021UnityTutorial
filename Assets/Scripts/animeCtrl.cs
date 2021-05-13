using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animeCtrl : MonoBehaviour
{
    public Animator ani;
    void Start()
    {
        
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            doAtkAni();
        }
    }
    void doAtkAni()
    {
        ani.SetTrigger("isAtk");
    }
}
