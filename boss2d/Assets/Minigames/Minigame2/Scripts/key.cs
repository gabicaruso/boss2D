using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour
{
    public GameObject door;
    // Start is called before the first frame update
   void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.CompareTag("Player"))
        {
            door.SetActive(false);
            Destroy(this.gameObject);
        }
        
    }
}
