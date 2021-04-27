using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
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
