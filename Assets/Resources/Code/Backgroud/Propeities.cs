using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Propeities : MonoBehaviour
{

    public int life, price, timerecharge, gameover = 3;
    private AudioClip sound;
    
    
    
    
    void Start()
    {
        
        sound = Resources.Load("Scenes/Sprites/Audios/Plant", typeof(AudioClip)) as AudioClip;

    }

   
    void Update()
    {
        CheckDeath();
        Checkmouse();
    }

    void CheckDeath()
    {
        if (life <= 0)
        {
            Destroy(gameObject);
        }

        if (gameover <= 0)
        {
            Debug.Log("ggggg");
        }
    }

    void Checkmouse()
    {
        if (GetComponent<Collider2D>().OverlapPoint(Camera.main.ScreenToWorldPoint(Input.mousePosition)))
        {
            OnMouseDown();
        }
    }

    private void OnMouseDown()
    {
        if (GameManager.ShovelEnabled && Input.GetMouseButtonDown(0))
        {
            GameManager.ShovelEnabled = false;
            AudioSource.PlayClipAtPoint(sound, Camera.main.transform.position);
            Destroy(gameObject);
        }
    }
}
