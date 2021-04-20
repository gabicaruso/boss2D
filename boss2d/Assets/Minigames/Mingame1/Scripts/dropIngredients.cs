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

    public void SpawnIngredients(){
        var firstElement = ingredients[0];

        GameObject obj = Instantiate(firstElement);
        Vector3 temp = transform.position;
        temp.z = 0f;
        obj.transform.position = temp;
        ingredients.RemoveAt(0);
    }
}
