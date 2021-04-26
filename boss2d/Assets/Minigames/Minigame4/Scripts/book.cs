using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class book : MonoBehaviour
{
    public static int points = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player"){
            points += 1;     
        }
        Destroy(gameObject);
    }
}
