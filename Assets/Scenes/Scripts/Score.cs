using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    int AIScore=0;
    int PlayerScore=0;
    public TMPro.TextMeshProUGUI AIText;
    public TMPro.TextMeshProUGUI PlayerText;

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
            this.transform.position=new Vector3(0f,0f,0f);
            rb.velocity=new Vector3(0f,0f,0f);
            AIScore++;
            AIText.text=AIScore.ToString();
        }
        else if(transform.position.x>9.5){
            this.transform.position=new Vector3(0f,0f,0f);
            rb.velocity=new Vector3(0f,0f,0f);
            PlayerScore++;
            PlayerText.text=PlayerScore.ToString();
        }
    }
}
