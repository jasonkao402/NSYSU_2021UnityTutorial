using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class playerCtrl : MonoBehaviour
{
    public Vector3 dir;
    [SerializeField]
    private float speed;
    public Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        dir = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * speed;
        if(dir.sqrMagnitude > 0.01f)
            rb.velocity = dir;
    }
}
