using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    
    public SpriteRenderer obj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     Defend(obj);

    }
    void Defend(SpriteRenderer gameObject){
        gameObject.color=new Vector4(0.5f,0.3f,0.2f,1f);
        // Debug.Log(gameObject.color);
    }
}
