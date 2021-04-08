using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public void Winner()
    {
        SceneManager.LoadScene("Menu");
    }
}
