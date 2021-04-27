using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class items : MonoBehaviour
{
    // public List<GameObject> ItemsToSpawn;
    public static int points = 0;
    private void OnTriggerEnter2D(Collider2D collision){
        Debug.Log("coll");
        if(collision.gameObject.tag == "Player"){
            points += 1;
            Debug.Log(points);
            Destroy(gameObject);  
            if(points == 5){
                SceneManager.LoadScene("VenceuMini3");
            }
            
        }

        if(collision.gameObject.tag == "chao"){
            SceneManager.LoadScene("PerdeuMini3");
        }

    }
}
