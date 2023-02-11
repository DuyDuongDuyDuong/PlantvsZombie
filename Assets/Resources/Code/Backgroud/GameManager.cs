using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;


public class GameManager : MonoBehaviour
{
    
    public GameObject Prefapsun;
    public Transform pointsun;
    public static int Cash;
    public static bool ShovelEnabled;
    public static GameObject currentPlant, currenseed;
    
    
    
    void Start()
    {
        InvokeRepeating("Instantiatesun",10 ,20);
        Cash = 50;
        ShovelEnabled = false;

    }
    void Update()
    {
        if (Cash >= 9999)
        {
            Cash = 9999;
            
        }
    }

    void Instantiatesun()
    {
        Instantiate(Prefapsun, pointsun.position, Quaternion.identity);
    }
    
   
    
    
    
}
