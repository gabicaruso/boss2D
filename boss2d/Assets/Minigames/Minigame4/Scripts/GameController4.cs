// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.SceneManagement;
// using UnityEngine.UI;

// public class GameController4 : MonoBehaviour
// {
//     public float startTime = 40.0f;
//     private float timer;
//     public static GameController3 instance;
//     public Text timeText;

    
//     private int moveCount;

//     void Start()
//     {
//       timer = startTime;
//     }

//     void Update()
//     {
//         DetectInput();
//     }

//     // void timer(){
//     //     timer = Time.deltaTime;
//     //     timeText = timer.ToString();
//     // }

//     public void EndGame(){
//         GameControl.vidas--;
//         //SceneManager.LoadScene("PerdeuMini1");
//     }

//     public void Winner(){
//         GameControl.pontos += 10;
//         //SceneManager.LoadScene("VenceuMini1");
//     }
// }
