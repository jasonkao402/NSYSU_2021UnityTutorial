using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public Transform pos;
    public GameObject[] bulletbag;
    public GameObject[] burstFireBag;
    public float maxtime, shootForce, offset, burstTime;
    private float nowtime;
    int i, len;
    public Animator animator;
    void Start()
    {
        len = bulletbag.Length;
    }
    // Update is called once per frame
    void Update()
    {
        if(nowtime <= 0)
        {
            if(Input.GetMouseButton(0)){
                animator.SetTrigger("isFire");
                //Rigidbody2D rb = Instantiate(bulletbag[(i++ % len)], transform.position + transform.up *offset, Quaternion.identity).GetComponent<Rigidbody2D>();
                //rb.velocity = transform.up * shootForce;
                StartCoroutine(Burstfire());
                nowtime = maxtime;
            }
        }
        else{
            nowtime -= Time.deltaTime;
        }
    }
    IEnumerator Burstfire()
    {
        int l = burstFireBag.Length;
        for(int i = 0; i < l; i++)
        {
            Rigidbody2D rb = Instantiate(burstFireBag[i], transform.position + transform.up *offset, Quaternion.identity).GetComponent<Rigidbody2D>();
            rb.velocity = transform.up * shootForce;
            yield return new WaitForSeconds(burstTime/l);
        }
    }
}
