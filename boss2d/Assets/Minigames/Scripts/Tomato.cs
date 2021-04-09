using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tomato : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D target){
        if(target.gameObject.tag == "bun"){
            if (transform.position.x - 0.5f < target.transform.position.x && transform.position.x + 0.5f > target.transform.position.x) {
                GameController.instance.Winner();
            }
        }
    }
}
