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

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	

	void FixedUpdate()
	{
        movement = Input.GetAxis("Horizontal");
		rb.velocity = new Vector2(movement * movementSpeed, rb.velocity.y);
        score = book.points;
        scoreText.text = "Score: " + score.ToString() + "/" + objective.ToString();
        if(score >= objective){
            SceneManager.LoadScene("VenceuMini4");
        }
        
	}
}