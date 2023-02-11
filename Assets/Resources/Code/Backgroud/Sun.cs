using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Sun : MonoBehaviour
{
    public float vel;
    [HideInInspector] public bool newInstace = false;
    public AudioClip Clip;
    private Rigidbody2D rb;
    private Collider2D _collider2D;
    
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
        _collider2D = GetComponent<Collider2D>();
        Destroy(gameObject, 7);
    }

    // Update is called once per frame
    void Update()
    {
        if (_collider2D.OverlapPoint(Camera.main.ScreenToWorldPoint(Input.mousePosition)))
        {
            OnMouseDown();
        }
    }

    private void FixedUpdate()
    {
        if (!newInstace)
        {
            rb.velocity = new Vector2(0, -vel * Time.deltaTime);
        }
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameManager.Cash += 25;
            AudioSource.PlayClipAtPoint(Clip, Camera.main.transform.position);
            Destroy(gameObject);
        }
    }
}
