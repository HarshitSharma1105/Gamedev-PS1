using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crossing : MonoBehaviour
{
//    public Rigidbody2D player;
   public Collider2D Collider2;

  void  OnTriggerEnter2D(Collider2D other){
    if(other.tag == "Player" || other.tag == "EnemyAI"){
    // player.velocity = new Vector3(0,0,0);
    Collider2.enabled = true;
    }
   }

   void OnTriggerExit2D(Collider2D other){
      Collider2.enabled = false;
   }
}