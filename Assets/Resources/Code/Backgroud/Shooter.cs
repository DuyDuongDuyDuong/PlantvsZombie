using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public float vel, damehit;
    public bool isIce;
    public AudioClip clip;

    private Rigidbody2D _rigidbody2D;
    private SpriteRenderer _spriteRenderer;
    
    
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
       // _spriteRenderer = GetComponent<SpriteRenderer>();
       
       
       Destroy(gameObject,8f);

    }

    // Update is called once per frame
    void Update()
    {
        // if (_spriteRenderer.isVisible)
        // {
        //     Destroy(gameObject);
        // }
    }

    private void FixedUpdate()
    {
        _rigidbody2D.velocity = new Vector2(vel * Time.deltaTime, 0);
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Zombie"))
        {
            if (isIce)
            {
                col.gameObject.GetComponent<ZombieScript>().walkSlow();
            }
            AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position);
            col.gameObject.GetComponent<ZombieScript>().life -= damehit;
            Destroy(gameObject);
        }
    }
}
