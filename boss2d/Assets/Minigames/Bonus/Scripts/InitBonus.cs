using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InitBonus : MonoBehaviour
{
    public void Init()
    {
        SceneManager.LoadScene("Bonus");
    }
}
