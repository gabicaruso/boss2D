using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    [HideInInspector]
    public int waypointIndex = 0;
    private int mini1 = 0;
    private int mini2 = 0;
    private int mini3 = 0;

    void Start(){
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
    }

    public void Winner()
    {
        // if (PlayerPrefs.HasKey("waypointIndex"))
        // {
        //     PlayerPrefs.SetInt("waypointIndex", 0);
        // }
        // if (PlayerPrefs.HasKey("mini1"))
        // {
        //     PlayerPrefs.SetInt("mini1", 0);
        // }
        // if (PlayerPrefs.HasKey("mini2"))
        // {
        //     PlayerPrefs.SetInt("mini2", 0);
        // }
        // if (PlayerPrefs.HasKey("mini3"))
        // {
        //     PlayerPrefs.SetInt("mini3", 0);
        // }
        PlayerPrefs.DeleteAll();
        waypointIndex = 0;
        mini1 = 0;
        mini2 = 0;
        mini3 = 0;
        SceneManager.LoadScene("Menu");
    }
}
