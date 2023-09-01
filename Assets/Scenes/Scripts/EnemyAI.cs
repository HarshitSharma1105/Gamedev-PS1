using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Transform Defender;
    public Transform Attacker;
    public Transform Ball;
    public Rigidbody2D rbBall;
    public Rigidbody2D rbDefender;
    private float movemenetX,movemenetY,movemenetAx,movemenetAy,hitspeed=20f,shootspeed=20f;
    public float horispeed=10f,verspeed=10f;

    void Update()
    {
       if(Defender.position.x<=1f){
        Defender.position=new Vector3((Defender.position.x)+5f*Time.deltaTime,Defender.position.y,0f);
        }
        else if(Defender.position.x>=6f){
        Defender.position=new Vector3((Defender.position.x)-5f*Time.deltaTime,Defender.position.y,0f);
        }
        if(Attacker.position.x<=7f){
        Attacker.position=new Vector3((Attacker.position.x)+5f*Time.deltaTime,Attacker.position.y,0f);
        }
       if(movingTowards() && isnotwithIt(Defender)){ 
        movemenetX=Mathf.MoveTowards(Defender.position.x,Ball.position.x,horispeed*Time.deltaTime);
        movemenetY=Mathf.MoveTowards(Defender.position.y,Ball.position.y,verspeed*Time.deltaTime); 
        Defender.transform.position=new Vector3(movemenetX,movemenetY,0f);
       }
       if(movingTowards() && isnotwithIt(Attacker)){ 
        movemenetAx=Mathf.MoveTowards(Attacker.position.x,Ball.position.x,horispeed*Time.deltaTime);
        movemenetAy=Mathf.MoveTowards(Attacker.position.y,Ball.position.y,verspeed*Time.deltaTime); 
        Attacker.transform.position=new Vector3(movemenetAx,movemenetAy,0f);
       }
       if(!isnotwithIt(Defender)){
        pass();
       }
       if(!isnotwithIt(Attacker)){
        shoot();
       }

    }
    bool movingTowards(){
        //Debug.Log("We reached movingtowards");
        float x=Vector2.Dot(rbBall.velocity,Vector2.left);
        return x<0f;
    }
    bool isnotwithIt(Transform enemy){
        //Debug.Log("We reached isnotwithit");
        return !((Ball.position-enemy.position).sqrMagnitude<.5f);
    }
    void pass(){
        Vector3 dir=(Defender.position-Attacker.position).normalized;
        rbBall.velocity=dir*hitspeed;
    }
    void shoot(){
        Vector3 shootdir=(new Vector3(-9.8f,0f,0f)-Attacker.position).normalized;
        rbBall.velocity=shootdir*shootspeed;
    }
    
    
}
