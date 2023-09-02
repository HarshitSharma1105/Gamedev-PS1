using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform player;
    public Transform Ball;
    public float horspeed=20f;
    public float verspeed=10f;
    float hori,ver;
    Rigidbody2D rb;
    public Rigidbody2D rbBall;

    void Start()
    {
     rb=GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void Update()
    {
        hori=Input.GetAxis("Horizontal")*horspeed;
        ver=Input.GetAxis("Vertical")*verspeed;
        if(transform.position.x>-.5f) hori=-Mathf.Abs(hori);
        rb.velocity=new Vector3(hori,ver,0);
        if(!isnotwithIt()){
         pass();
       }

    }
    bool isnotwithIt(){
        return !((Ball.position-player.position).sqrMagnitude<.5f);
    }
    void pass(){
        Vector3 dir=(new Vector3(9.8f,0f,0f)-player.position).normalized;
        rbBall.velocity=dir*20f;
    }

    
}
