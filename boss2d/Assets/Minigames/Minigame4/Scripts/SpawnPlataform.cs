using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnPlataform : MonoBehaviour
{
    public GameObject player;
    public GameObject platformPrefab;
    public GameObject bookPrefab;
    // public GameObject book;

    public float jumpForce = 10f;
    public int points = 0;
    public Text scoreText;

    // SpriteRenderer sprite;
    // float bottomOfScreen;

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.name.StartsWith("plataform")){
            if(Random.Range(1,5) == 1){
                Destroy(collision.gameObject);
                Vector2 spawnPosition = new Vector2(Random.Range(-6f,6f),player.transform.position.y + (14 + Random.Range(0.5f,1f)));
                Instantiate(platformPrefab, spawnPosition,  Quaternion.identity ); 
                Vector2 spawnBookPosition = new Vector2(Random.Range(-6f,6f),player.transform.position.y + (16 + Random.Range(0.5f,1f)));
                Instantiate(bookPrefab, spawnBookPosition,  Quaternion.identity);
            }else
            {
                collision.gameObject.transform.position = new Vector2(Random.Range(-5.5f,5.5f),player.transform.position.y + (14 + Random.Range(0.2f,1f)));
            }
        }

        if(collision.gameObject.name.StartsWith("book")){
            points += 1;
            scoreText.text = "Score:" + points.ToString();
        }
    }


	// Use this for initialization
	// void Start () {

    //     sprite = GetComponent<SpriteRenderer>();

    //     var cam = Camera.main;
    //     var screen = new Vector2(Screen.width, Screen.height);
    //     var camWorldPos = cam.ScreenToWorldPoint(screen);
    //     bottomOfScreen = camWorldPos.y - cam.orthographicSize * 2;
	// }

    // public void OnBecameInvisible() 
    // {
    //     Destroy(gameObject);
    // }
}
