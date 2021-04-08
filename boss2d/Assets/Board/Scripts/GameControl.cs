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
                SceneManager.LoadScene("MinigameTest");
            }
            if (PlayerPrefs.GetInt("mini2") ==  1)
            {
                PlayerPrefs.SetInt("mini2", 2);
                SceneManager.LoadScene("MinigameTest");
            }
            if (PlayerPrefs.GetInt("mini3") ==  1)
            {
                PlayerPrefs.SetInt("mini3", 2);
                SceneManager.LoadScene("MinigameTest");
            }
        }

        if (player1.GetComponent<FollowThePath>().waypointIndex == player1.GetComponent<FollowThePath>().waypoints.Length)
        {
            if (PlayerPrefs.HasKey("waypointIndex"))
            {
                PlayerPrefs.GetInt("waypointIndex");
            }
            if (PlayerPrefs.HasKey("mini1"))
            {
                PlayerPrefs.GetInt("mini1");
            }
            if (PlayerPrefs.HasKey("mini2"))
            {
                PlayerPrefs.GetInt("mini2");
            }
            if (PlayerPrefs.HasKey("mini3"))
            {
                PlayerPrefs.GetInt("mini3");
            }
            gameOver = true;
            SceneManager.LoadScene("EndGame");
        }
    }

    public static void MovePlayer()
    {
        player1.GetComponent<FollowThePath>().moveAllowed = true;
    }
}
