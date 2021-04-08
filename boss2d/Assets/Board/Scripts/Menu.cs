using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Game()
    {
        GameControl.diceSideThrown = 0;
        GameControl.player1StartWaypoint = 0;
        GameControl.vidas = 3;
        GameControl.pontos = 0;
        GameControl.gameOver = false;
        Dice.coroutineAllowed = true;
        SceneManager.LoadScene("SampleScene");
    }
}
