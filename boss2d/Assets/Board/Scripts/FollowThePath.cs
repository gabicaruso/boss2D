using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.SceneManagement;

public class FollowThePath : MonoBehaviour
{
    public Transform[] waypoints;

    [SerializeField]
    private float moveSpeed = 1f;

    [HideInInspector]
    public int waypointIndex = 0;

    public bool moveAllowed = false;

    Animator animator;

    void Start()
    {
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
                waypointIndex++;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.CompareTag("minigame1"))
        {
            Debug.Log("minigame1");
            animator.SetBool("minigame", true);
            // SceneManager.LoadScene("MinigameTest");
        }
        if(col.gameObject.CompareTag("minigame2"))
        {
            Debug.Log("minigame2");
            animator.SetBool("minigame", false);
            // SceneManager.LoadScene("MinigameTest");
        }
        if(col.gameObject.CompareTag("minigame3"))
        {
            Debug.Log("minigame3");
            animator.SetBool("minigame", true);
            // SceneManager.LoadScene("MinigameTest");
        }
        if(col.gameObject.CompareTag("winner"))
        {
            animator.SetBool("minigame", false);
        }
    }
}
