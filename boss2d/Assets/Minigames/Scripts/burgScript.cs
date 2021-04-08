using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class burgScript : MonoBehaviour
{
    private float min_X = -4.5f, max_F = 4.5f;
    private bool canMove;
    private float moveSpeed = 15f;
    private Rigidbody2D myBody;
    private bool gameOver;
    private bool ignoreCollision;
    private bool ignoreTrigger ;

    public int ingCount = 0;
    // Start is called before the first frame update
    
    void Awake(){
        myBody = GetComponent<Rigidbody2D>();
        myBody.gravityScale = 0f;
        //Debug.Log(myBody.gravityScale);
    }

    void Start()
    {
       
       canMove = true; 
       if(Random.Range(0,2) > 0){
           moveSpeed *= -1f;
       }
       GameController.instance.currentIng = this;
    }

    // Update is called once per frame
    void Update()
    {
        MoveBox();
    }
    void MoveBox(){
        if(canMove){
            Vector3 temp = transform.position;
            temp.x += moveSpeed * Time.deltaTime;
            if(temp.x > max_F){
                moveSpeed *= -1f;
            }
            else if(temp.x < min_X){
                moveSpeed *= -1f;
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
        ignoreTrigger = true;

        GameController.instance.SpawnNewIngredient();
        
    }

    void EndGame(){
        GameController.instance.EndGame();
    }

    void OnCollisionEnter2D(Collision2D target){
        if(ignoreCollision){
            return;
        }
        if(target.gameObject.tag == "bottonBun"){
            Invoke("Landed",2f);
            ignoreCollision = true;

        }

        if(target.gameObject.tag == "burger"){
            Invoke("Landed",2f);
            ignoreCollision = true;
            
        }

        if(target.gameObject.tag == "tomato"){
            //Invoke("Landed",2f);
            ignoreCollision = true;
        }

    }

    void OnTriggerEnter2D(Collider2D target){
        if(ignoreTrigger){
            return;
        }
        if(target.tag == "GameOver"){
            CancelInvoke("Landed");
            gameOver = true;
            ignoreTrigger = true;
            Invoke("EndGame",2f);

        }


    }
}