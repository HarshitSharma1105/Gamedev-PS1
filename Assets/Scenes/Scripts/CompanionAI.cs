using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompanionAI : MonoBehaviour
{
    public Transform Defender;
    public Transform Attacker;
    public Transform Ball;
    public Rigidbody2D rbBall;
    public Rigidbody2D rbDefender;
    float movemenetX,movemenetY,hitspeed=10f;
    public float horispeed=20f,verspeed=20f;


    void Start()
    {
        
    }

    void Update()
    {
       if(Defender.position.x>=-8f){
        Defender.position=new Vector3(Defender.position.x-.2f,Defender.position.y,0f);
        }
       if(movingTowards() && isnotwithIt()){ 
        movemenetX=Mathf.MoveTowards(Defender.position.x,Ball.position.x-.1f,horispeed*Time.deltaTime);
        movemenetY=Mathf.MoveTowards(Defender.position.y,Ball.position.y,verspeed*Time.deltaTime); 
        Defender.transform.position=new Vector3(movemenetX,movemenetY,0f);
       }
        if(!isnotwithIt()){
         pass();
       }

    }
    bool movingTowards(){
        Debug.Log("We reached movingtowards");
        float x=Vector2.Dot(rbBall.velocity,Vector2.right);
        return x<0f;
    }
    bool isnotwithIt(){
        Debug.Log("We reached isnotwithit");
        return !((Ball.position-Defender.position).sqrMagnitude<.5f);
    }
    void pass(){
        Debug.Log("We reached pass");
        Vector3 dir=(new Vector3(3.8f,1.8f,0f)-Attacker.position).normalized;
        rbBall.velocity=dir*hitspeed;
    }
    
}