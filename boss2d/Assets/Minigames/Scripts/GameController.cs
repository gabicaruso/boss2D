using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public dropIngredients dropIng;
    [HideInInspector]
    public burgScript currentIng;
    
    private int moveCount;

    void Awake(){
        if(instance == null){
            instance = this;
        }
    }

    void Start()
    {
      dropIng.SpawnIngredients(); 
      Debug.Log("start");
    }

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
        SceneManager.LoadScene("PerdeuMini1");
        Debug.Log("perdeu");
    }

    public void Winner(){
        SceneManager.LoadScene("VenceuMini1");
        Debug.Log("ganhou");
    }
}
