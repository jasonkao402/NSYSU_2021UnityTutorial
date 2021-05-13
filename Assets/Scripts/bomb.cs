using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : MonoBehaviour
{
    public float maxtime, radius, blast;
    public GameObject expEff;
    void Start()
    {
        Invoke("Detonate", maxtime);
    }
    void Detonate()
    {
        Instantiate(expEff, transform.position, Quaternion.identity);
        Collider2D[] tgt = Physics2D.OverlapCircleAll(transform.position, radius);
        foreach(Collider2D col in tgt)
        {
            Rigidbody2D rb = col.gameObject.GetComponent<Rigidbody2D>();
            if(col.transform.root!= transform && rb != null){
                Vector3 dpos = rb.transform.position - transform.position;
                rb.AddForce(blast * dpos / dpos.sqrMagnitude, ForceMode2D.Impulse);
            }
        }
        Destroy(gameObject);
    }
}
