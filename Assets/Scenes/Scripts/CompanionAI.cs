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
    float movemenetX,movemenetY,hitspeed=20f;
    public float horispeed=20f,verspeed=20f;


    void Start()
    {
        
    }

    void Update()
    {
<<<<<<< Updated upstream
       if(Defender.position.x>-7f){
        Defender.position=new Vector3((Defender.position.x)-5f*Time.deltaTime,Defender.position.y,0f);
=======
       if(Defender.position.x>-3f){
        Defender.position=new Vector3((Defender.position.x)-.3f,Defender.position.y,0f);
>>>>>>> Stashed changes
        }
       if(movingTowards() && isnotwithIt()){ 
        movemenetX=Mathf.MoveTowards(Defender.position.x,Ball.position.x,.1f*horispeed*Time.deltaTime);
        movemenetY=Mathf.MoveTowards(Defender.position.y,Ball.position.y,verspeed*Time.deltaTime); 
        Defender.transform.position=new Vector3(movemenetX,movemenetY,0f);
       }
        if(!isnotwithIt()){
         pass();
       }

    }
    bool movingTowards(){
        float x=Vector2.Dot(rbBall.velocity,Vector2.right);
        return x<0f;
        // return (Ball.position.x>0f);
    }
    bool isnotwithIt(){
        return !((Ball.position-Defender.position).sqrMagnitude<.5f);
    }
    void pass(){
        Vector3 dir=(Attacker.position-Defender.position).normalized;
        rbBall.velocity=dir*hitspeed;
    }
    
}