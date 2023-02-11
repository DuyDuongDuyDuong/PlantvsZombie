using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shovel : MonoBehaviour
{

    public AudioSource soud;
    
     void OnMouseDown()
    {
        if (GameManager.currentPlant == null && !GameManager.ShovelEnabled)
        {
            GameManager.ShovelEnabled = true;
            soud.Play();
            Instantiate(Resources.Load("Prefap/BG/Sprite", typeof(GameObject)) as GameObject,transform.position, Quaternion.identity);
            
             
        }
    }
}
