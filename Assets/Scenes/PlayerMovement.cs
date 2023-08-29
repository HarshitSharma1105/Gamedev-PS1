using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform player;
    public float horspeed=20f;
    public float verspeed=10f;
    Rigidbody2D rb;
    void Start()
    {
     rb=GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void Update()
    {
        float hori=Input.GetAxis("Horizontal")*horspeed;
        float ver=Input.GetAxis("Vertical")*verspeed;

        rb.velocity=new Vector3(hori,ver,0);

        
    }
}
