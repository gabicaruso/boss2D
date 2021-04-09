using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class burgScript : MonoBehaviour
{
    private float min_X = -4.5f, max_F = 4.5f;
    private bool canMove;
    private float moveSpeed = 12f;
    private Rigidbody2D myBody;
    public static bool gameOver;
    private bool ignoreCollision;

    public int ingCount = 0;
    
    void Awake(){
        myBody = GetComponent<Rigidbody2D>();
        myBody.gravityScale = 0f;
    }

    void Start()
    {
       canMove = true; 
       if(Random.Range(0,2) > 0){
           moveSpeed *= -1f;
       }
       GameController.instance.currentIng = this;
    }

    void Update()
    {
        MoveBox();
    }
    void MoveBox(){
        if(canMove){
            Vector3 temp = transform.position;
    
            temp.x += moveSpeed * Time.deltaTime;
            if(temp.x > max_F){
                moveSpeed = -12.0f;
            }
            else if(temp.x < min_X){
                moveSpeed = 12.0f;
            }
            transform.position = temp;
        }
    }
    public void DropIng(){
        canMove = false;
        myBody.gravityScale = Random.Range(2,4);
    }

    void Landed(){
        if(gameOver){
            return;
        }
        ignoreCollision = true;

        GameController.instance.SpawnNewIngredient();
    }

    void OnCollisionEnter2D(Collision2D target){
        if(ignoreCollision){
            return;
        }
        if(target.gameObject.tag == "bottonBun"){
            Invoke("Landed",0.5f);
            ignoreCollision = true;
        }

        if(target.gameObject.tag == "burger"){
            Invoke("Landed",0.5f);
            ignoreCollision = true;
        }
    }
}