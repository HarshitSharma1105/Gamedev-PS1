using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{

    int AIscore=0;
    int Playerscore=0;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x<-9.5){
            Debug.Log("Goal for AI");
            this.transform.position=new Vector3(0f,0f,0f);
            rb.velocity=new Vector3(0f,0f,0f);
            AIscore++;
        }
        else if(transform.position.x>9.5){
            Debug.Log("Goal for Player");
            this.transform.position=new Vector3(0f,0f,0f);
            rb.velocity=new Vector3(0f,0f,0f);
            Playerscore++;
        }
    }
}
