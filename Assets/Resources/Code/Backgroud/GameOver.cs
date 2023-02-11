using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{

    public static bool isGameover;
    public GameObject gameoversceen;

    private void Awake()
    {
        isGameover = false;
    }

    private void Update()
    {
        if (isGameover)
        {
            gameoversceen.SetActive(true);
        }
    }
}
