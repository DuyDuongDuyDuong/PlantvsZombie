using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieScript : MonoBehaviour
{
    
    
    public float life, vel;
    private bool canWalk, canEat;
    private Rigidbody2D rb;
    private Animator _anim;
    private AudioSource sound;
    private SpriteRenderer _spriteRenderer;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
        sound = GetComponent<AudioSource>();
        canEat = true;
        _spriteRenderer = GetComponent<SpriteRenderer>();
        

    }

    // Update is called once per frame
    void Update()
    {
        CheckDeat();
        CheckPlant();
       // Deat();
    }

    private void FixedUpdate()
    {
        rb.velocity = canWalk ? new Vector2(-vel * Time.deltaTime, 0) : Vector2.zero;
        
        
    }

    void CheckDeat()
    {
        if (life <= 0)
        {
            Destroy(gameObject);
            
        }
    }

    void CheckPlant()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.right, 0.3f, LayerMask.GetMask("Plant"));
        if (hit.collider != null)
        {
            _anim.SetBool("isEatZombie",true);
            canWalk = false;
            if (canEat)
            {
                StartCoroutine(Eat(hit.collider));
            }
           
            if (!sound.isPlaying)
            {
                sound.Play();
            }

        }
        else
        {
            StopCoroutine("Eat");
            sound.Stop();
            canWalk = true;
            canEat = true;
            _anim.SetBool("isEatZombie",false);
        }

    }

    IEnumerator Eat(Collider2D collider2D)
    {
        canEat = false;
        yield return new WaitForSeconds(2f);
        canEat = true;
        if (collider2D != null)
        {
            collider2D.gameObject.GetComponent<Propeities>().life--;
        }
        
        
    }
    
    public void walkSlow()
    {
        StopCoroutine("WalkFast");
        _spriteRenderer.material.color = Color.cyan;
        vel = 8;
        StartCoroutine("WalkFast");
    }
    
    IEnumerator WalkFast()
    {
        yield return new WaitForSeconds(5);
        _spriteRenderer.material.color= Color.white;
        vel = 15;
    }




    // public GameOver gameOver4;
    // private bool _deat = false;
    //
    // private void OnTriggerEnter2D(Collider2D col)
    // {
    //     if (col.CompareTag("limit"))
    //     {
    //         _deat = true;
    //         //Destroy(gameObject);
    //         Debug.Log("dgtgttgttg");
    //
    //     }
    // }
    //
    // void Deat()
    // {
    //     if (_deat == true)
    //     {
    //         Debug.Log("dsdsdsd");
    //         gameOver4.GameOverd();
    //     }
    // }





   
   
    // private void OnTriggerEnter2D(Collider2D col)
    // {
    //     if (col.CompareTag("limit") && !_Deat)
    //     {
    //         _Deat = true;
    //         gameOver4.GameOverd();
    //        Destroy(gameObject);
    //         
    //
    //     }
}

  
    
    
    

