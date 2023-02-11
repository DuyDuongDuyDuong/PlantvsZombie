using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PeaShooterGun : MonoBehaviour
{
    public GameObject PrefapPea;
    private float distance;
    
    void Start()
    {
        InvokeRepeating("Shooter",0,2);
        distance = 7f - transform.position.x;
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Shooter()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right, distance, LayerMask.GetMask("Zombie"));
        if (hit.collider != null)
        {
            Instantiate(PrefapPea, transform.position, quaternion.identity);
        }
    }
}
