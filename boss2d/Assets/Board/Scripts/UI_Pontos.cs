using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Pontos : MonoBehaviour
{
    Text textComp;

    void Start()
    {
        textComp = GetComponent<Text>();
    }
    
    void Update()
    {
        textComp.text = $"Pontos: {GameControl.pontos}";
    }
}