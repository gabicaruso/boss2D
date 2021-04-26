using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public float velocidade = 5.0f;
    private Rigidbody2D myBody;

    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
        myBody.gravityScale = 0f;  
    }

    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");
        
        transform.position += new Vector3(inputX,inputY,0) * Time.deltaTime * velocidade;  
    }
}
