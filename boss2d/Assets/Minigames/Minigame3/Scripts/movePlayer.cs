using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movePlayer : MonoBehaviour
{
    public float velocidade = 5.0f;
    private Rigidbody2D myBody;
    
    void Update()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal"),0,0) * Time.deltaTime * velocidade;
    }

    void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.tag == "baditem"){
            GameControl.vidas--;
            SceneManager.LoadScene("PerdeuMini3");
            Destroy(collision.gameObject);  
        }

    }

}
