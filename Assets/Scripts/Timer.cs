using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour
{
    float timeleft=300f;
    bool timeranout;

    public TMPro.TextMeshProUGUI TimerText;
    // Start is called before the first frame update
    void Start()
    {
        timeranout=false;
    }

    // Update is called once per frame
    void Update()
    {
        if(!timeranout){
            if(timeleft>=0f){
                timeleft-=Time.deltaTime;
                updateTimer(timeleft);
            }
            else {
                timeranout=true;
            }
        }
        else{
            SceneManager.LoadScene("MainMenu");
        }
    }
    void updateTimer(float time){
        time+=1f;
        float minutes=(float)((int)time/60);
        float seconds=(float)((int)time%60);
        TimerText.text=string.Format("{0:00}:{1:00}",minutes,seconds);
    }
}
