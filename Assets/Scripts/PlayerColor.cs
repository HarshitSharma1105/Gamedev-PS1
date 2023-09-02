using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerColor : MonoBehaviour
{
    private Image img;
    SpriteRenderer sr,sr1;
    // Start is called before the first frame update
    void Start()
    {
      //color=new Vector4(.354f,.350f,.785f,1f);
      sr=GameObject.Find("Player").GetComponent<SpriteRenderer>();
      sr1=GameObject.Find("Companion").GetComponent<SpriteRenderer>();
      img=GetComponent<Image>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void  Setter(){
        sr.color=img.color;
        sr1.color=img.color;
    }
    
}
