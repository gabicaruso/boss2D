using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public dropIngredients dropIng;
    [HideInInspector]
    public burgScript currentIng;
    
    private int moveCount;

    // Start is called before the first frame update
    
    void Awake(){
        if(instance == null){
            instance = this;
        }

    }
    // Start is called before the first frame update
    void Start()
    {
      dropIng.SpawnIngredients(); 
      Debug.Log("start");
    }

    // Update is called once per frame
    void Update()
    {
        DetectInput();
        
    }

    void DetectInput(){
        if(Input.GetKey("space")){
            currentIng.DropIng();
        }
    }

    public void SpawnNewIngredient(){
        Invoke("NewIngredient",1f);

    }

    void NewIngredient(){
        dropIng.SpawnIngredients();
    }

    public void EndGame(){
        //UnityEngine.SceneManagement.SceneManager.LoadScene();
        Debug.Log("endgame");
    }
}
