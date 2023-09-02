using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{

    int AIScore=0;
    int PlayerScore=0;
    int maxscore=5;
    public TMPro.TextMeshProUGUI AIText;
    public TMPro.TextMeshProUGUI PlayerText;

    public AudioSource audioSource;

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
            audioSource.Play();
            this.transform.position=new Vector3(0f,0f,0f);
            rb.velocity=new Vector3(0f,0f,0f);
            AIScore++;
            if(AIScore>maxscore){
                SceneManager.LoadScene("MainMenu");
            }
            AIText.text=AIScore.ToString();
        }
        else if(transform.position.x>9.5){
            audioSource.Play();
            this.transform.position=new Vector3(0f,0f,0f);
            rb.velocity=new Vector3(0f,0f,0f);
            PlayerScore++;
            if(PlayerScore>maxscore){
                SceneManager.LoadScene("MainMenu");
            }
            PlayerText.text=PlayerScore.ToString();
        }
    }
}
