using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FollowThePath : MonoBehaviour
{
    public Transform[] waypoints;

    [SerializeField]
    private float moveSpeed = 1f;

    [HideInInspector]
    public int waypointIndex = 0;

    public bool moveAllowed = false;

    Animator animator;

    private int mini1 = 0;
    private int mini2 = 0;
    private int mini3 = 0;
    private int mini4 = 0;

    void Start()
    {
        if (PlayerPrefs.HasKey("waypointIndex"))
        {
            waypointIndex = PlayerPrefs.GetInt("waypointIndex");
        }
        mini1 = PlayerPrefs.GetInt("mini1");
        mini2 = PlayerPrefs.GetInt("mini2");
        mini3 = PlayerPrefs.GetInt("mini3");
        mini4 = PlayerPrefs.GetInt("mini4");

        transform.position = waypoints[waypointIndex].transform.position;
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (moveAllowed) {
            Move();
        }
    }

    private void Move()
    {
        if (waypointIndex <= waypoints.Length - 1)
        {
            transform.position = Vector2.MoveTowards(transform.position, waypoints[waypointIndex].transform.position, moveSpeed * Time.deltaTime);

            if (transform.position == waypoints[waypointIndex].transform.position)
            {
                PlayerPrefs.SetInt("waypointIndex", waypointIndex);
                waypointIndex++;
            } 
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.CompareTag("minigame1") && mini1 == 0)
        {
            animator.SetBool("minigame", true);
            PlayerPrefs.SetInt("mini1", 1);
        }
        if(col.gameObject.CompareTag("minigame2") && mini2 == 0)
        {
            animator.SetBool("minigame", true);
            PlayerPrefs.SetInt("mini2", 1);
        }
        if(col.gameObject.CompareTag("minigame3") && mini3 == 0)
        {
            animator.SetBool("minigame", true);
            PlayerPrefs.SetInt("mini3", 1);
        }
        if(col.gameObject.CompareTag("minigame4") && mini4 == 0)
        {
            animator.SetBool("minigame", true);
            PlayerPrefs.SetInt("mini4", 1);
        }
    }
}
