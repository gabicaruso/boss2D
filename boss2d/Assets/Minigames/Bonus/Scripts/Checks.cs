using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checks : MonoBehaviour
{
    private Sprite[] checks;
    private SpriteRenderer rend;

    private Vector3[] lista;

    private void Start()
    {
        lista = new Vector3[] {new Vector3(-5f, -0.5f, 0f), new Vector3(-0f, -0.5f, 0f), new Vector3(5f, -0.5f, 0f)};
        
        GameObject child0 = gameObject.transform.GetChild(0).gameObject;
        GameObject child1 = gameObject.transform.GetChild(1).gameObject;
        GameObject child2 = gameObject.transform.GetChild(2).gameObject;

        int randomNum = Random.Range(0, 2);
        child0.transform.position = lista[randomNum];

        int randomNum2 = Random.Range(0, 2);
        if(randomNum == 0)
        {
            if(randomNum2 == 0)
            {
                child1.transform.position = lista[randomNum2];
            }
            if(randomNum2 == 1)
            {
                child2.transform.position = lista[randomNum2];
            }
        }


        // rend = GetComponent<SpriteRenderer>();
        // checks = Resources.LoadAll<Sprite>("Checks/");
        // rend.sprite = checks[2];

        // int randomCheck = 0;
        // randomCheck = Random.Range(0, 3);
        // rend.sprite = checks[randomCheck];
        // Debug.Log(randomCheck);
    }

    // void OnCollisionEnter2D(Collision2D col)
    // {
    //     if(col.gameObject.tag == "check"){
    //         Debug.Log("check");
    //     }
    //     if(col.gameObject.tag == "close"){
    //         Debug.Log("close");
    //     }
    // }
}