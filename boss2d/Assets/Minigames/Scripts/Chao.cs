using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chao : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D target){
        GameController.instance.EndGame();
    }
}
