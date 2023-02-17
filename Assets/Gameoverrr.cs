using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameoverrr : MonoBehaviour
{
    private int _Scout = 0;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Zombie"))
        {
            _Scout += 1;
            if (_Scout == 3)
            {
                GameOver.isGameover = true;
            }
            
           
        }
    }
}
