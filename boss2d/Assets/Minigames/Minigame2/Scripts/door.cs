using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    GameController2 gc;

    void OnCollisionEnter2D(Collision2D col)
    {
        GameController2.instance.Winner();
    }
}
