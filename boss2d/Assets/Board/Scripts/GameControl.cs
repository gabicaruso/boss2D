using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    private static GameObject player1;

    public static int diceSideThrown = 0;
    public static int player1StartWaypoint = 0;

    public static bool gameOver = false;

    public static int vidas = 3;
    public static int pontos = 0;

    void Start()
    {
        player1 = GameObject.Find("Player1");

        player1.GetComponent<FollowThePath>().moveAllowed = false;
    }

    void Update()
    {
        if (player1.GetComponent<FollowThePath>().waypointIndex > player1StartWaypoint + diceSideThrown)
        {
            player1.GetComponent<FollowThePath>().moveAllowed = false;
            player1StartWaypoint = player1.GetComponent<FollowThePath>().waypointIndex - 1;

            if (PlayerPrefs.GetInt("mini1") ==  1)
            {
                PlayerPrefs.SetInt("mini1", 2);
                SceneManager.LoadScene("Init1");
            }
            if (PlayerPrefs.GetInt("mini2") ==  1)
            {
                PlayerPrefs.SetInt("mini2", 2);
                SceneManager.LoadScene("Init2");
            }
            if (PlayerPrefs.GetInt("mini3") ==  1)
            {
                PlayerPrefs.SetInt("mini3", 2);
                SceneManager.LoadScene("Init1");
            }
        }

        if (vidas <= 0)
        {
            PlayerPrefs.DeleteAll();
            gameOver = true;
            SceneManager.LoadScene("Lost");
        }

        if (player1.GetComponent<FollowThePath>().waypointIndex == player1.GetComponent<FollowThePath>().waypoints.Length)
        {
            gameOver = true;
            SceneManager.LoadScene("EndGame");
        }
    }

    public static void MovePlayer()
    {
        player1.GetComponent<FollowThePath>().moveAllowed = true;
    }
}
