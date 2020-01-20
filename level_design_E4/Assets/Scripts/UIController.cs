using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Image[] diamonds;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < diamonds.Length; i++)
        {
            diamonds[i].color = Color.clear;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    internal void displayNewDiamond(uint amountOfDiamonds)
    {
        for (int i = 0; i < amountOfDiamonds; i++)
        {
            diamonds[i].color = Color.white;
        }
    }
}
