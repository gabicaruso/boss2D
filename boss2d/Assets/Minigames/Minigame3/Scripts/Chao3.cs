using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Chao3 : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.tag == "baditem"){
            Destroy(collision.gameObject);  
        }

    }
}
