using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropIngredients : MonoBehaviour
{

    public List<GameObject> ingredients = new List<GameObject>();
    public GameObject bun,burg,tomato;
    private Vector2 screenbounds;

    public static GameController gm;

    void Awake()
    {
        ingredients.Add(burg);
        ingredients.Add(tomato);
        ingredients.Add(bun);
    }

    void Winner(){
        GameController.instance.Winner();
    }

    public void SpawnIngredients(){
        var firstElement = ingredients[0];
        Debug.Log(firstElement);

        GameObject obj = Instantiate(firstElement);
        Vector3 temp = transform.position;
        temp.z = 0f;
        obj.transform.position = temp;
        ingredients.RemoveAt(0);
        
        if(ingredients.Count == 0){
            Invoke("Winner",2f);
        }

    }
}
