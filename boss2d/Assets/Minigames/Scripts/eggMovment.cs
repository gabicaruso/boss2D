using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eggMovment : MonoBehaviour
{
    //public float vel = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // transform.Translate(0,- vel * Time.deltaTime,0);
    }

    public GameObject egg;

    void OnTriggerEnter2D(Collider2D col)
    {
        // if (col.tag == "egg")
        // {
        //     // Debug.Log("bun2 collected");
        //     col.gameObject.transform.parent = egg.transform;
        // }
    }
}
