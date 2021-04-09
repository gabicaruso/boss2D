using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MinigameTest : MonoBehaviour
{
    public void Voltar()
    {
        if(GameControl.vidas > 0){
            SceneManager.LoadScene("SampleScene");
        }
        else if(GameControl.vidas <= 0){
            SceneManager.LoadScene("Lost");
        }
    }
}
