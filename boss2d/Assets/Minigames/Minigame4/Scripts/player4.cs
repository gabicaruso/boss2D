using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class player4 : MonoBehaviour
{
	Rigidbody2D rb;

	float movement = 0f;
    public float movementSpeed = 10f;
    private static int score;
    public int objective = 5;
    public Text scoreText;
    private float top = 0.0f;

	void Start () 
    {
		rb = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate()
	{
        if(rb.velocity.y > 0 && transform.position.y > top){
            top = transform.position.y;
        }
        
        if(transform.position.y + 20 < top)
        {
            GameControl.vidas--;
            SceneManager.LoadScene("PerdeuMini4");
        }

        movement = Input.GetAxis("Horizontal");
		rb.velocity = new Vector2(movement * movementSpeed, rb.velocity.y);
        score = book.points;
        scoreText.text = "Score: " + score.ToString() + "/" + objective.ToString();

        if(score >= objective)
        {
            GameControl.pontos += 10;
            SceneManager.LoadScene("VenceuMini4");
        }
	}
}