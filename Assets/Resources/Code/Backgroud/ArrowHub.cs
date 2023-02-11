using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowHub : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioSource soud;
    
    private void OnMouseDown()
    {
        if (GameManager.currentPlant != null || GameManager.ShovelEnabled)
        {
            GameManager.currentPlant = null;
            GameManager.currenseed = null;
            GameManager.ShovelEnabled = false;
            soud.Play();
            
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
