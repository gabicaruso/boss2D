using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController2 : MonoBehaviour
{
    public static GameController2 instance;
    public float startTime = 5.0f;
    private float timer;
    public Text timerText;

    private int iTime;

    
    private int moveCount;

    void Start()
    {
        if(instance == null){
            instance = this;
        }
        timer = startTime;
    }

    void Update()
    {
        if(timer > 0){
            Timer();
        }
        else{
            EndGame();
        }
    }

    void Timer(){
        timer -= Time.deltaTime;
        iTime = (int)timer;
        timerText.text = iTime.ToString();
    }

    public void EndGame(){
        GameControl.vidas--;
        SceneManager.LoadScene("PerdeuMini2");
    }

    public void Winner(){
        GameControl.pontos += 10;
        SceneManager.LoadScene("VenceuMini2");
    }
}
