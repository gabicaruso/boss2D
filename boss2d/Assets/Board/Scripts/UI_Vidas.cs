﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Vidas : MonoBehaviour
{
    Text textComp;

    void Start()
    {
        textComp = GetComponent<Text>();
    }
    
    void Update()
    {
        textComp.text = $"Vidas: {GameControl.vidas}";
    }
}