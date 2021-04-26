using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


// [RequireComponent(typeof(Rigidbody2D))]
public class player4 : MonoBehaviour {

	Rigidbody2D rb;

	float movement = 0f;
    public float movementSpeed = 10f;
    private static int score;
    public int objective = 10;
    public Text scoreText;
    private float top = 0.0f;
    // public GameObject Player;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}

    // void update(){
    //      Debug.Log("start");



    // }
	

	void FixedUpdate()
	{
        // Debug.Log("start");
        if(rb.velocity.y > 0 && transform.position.y > top){
            top = transform.position.y;
            Debug.Log(transform.position.y);
        }
        
        if(transform.position.y + 20 < top){
            Debug.Log(transform.position.y);
            SceneManager.LoadScene("PerdeuMini4");
            //top = tranform.position.y;
        }
        movement = Input.GetAxis("Horizontal");
		rb.velocity = new Vector2(movement * movementSpeed, rb.velocity.y);
        score = book.points;
        scoreText.text = "Score: " + score.ToString() + "/" + objective.ToString();
        if(score >= objective){
            SceneManager.LoadScene("VenceuMini4");
        }
        
	}
}