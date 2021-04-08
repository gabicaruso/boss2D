using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bunMovment : MonoBehaviour
{
    // Start is called before the first frame update
        // Objetos a serem gerenciados
    public GameObject bun;
    public float velocidade = 5;
    private Vector2 screenbounds;
    void Start()
    {
        bun = GameObject.Find("bunBottom");
        //screenbounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width,Screen.height,Camera.main.transform.position.z));
    
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(bun.transform.position);
        float inputX = Input.GetAxis("Horizontal");
        transform.position += new Vector3(inputX,0,0) * Time.deltaTime * velocidade;

    }
}
