using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameoverrr : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Zombie"))
        {
            GameOver.isGameover = true;
        }
    }
}
