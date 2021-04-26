using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
   // public Rigidbody2D rb;
    public float velocidade = 5.0f;
    private Rigidbody2D myBody;

    //public Transform player;
    

    // Start is called before the first frame update
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
        myBody.gravityScale = 0f;
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");
        
        transform.position += new Vector3(inputX,inputY,0) * Time.deltaTime * velocidade;
        
    }
}
