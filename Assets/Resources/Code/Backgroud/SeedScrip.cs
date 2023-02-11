using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEditor.Build.Content;
using UnityEngine;

public class SeedScrip : MonoBehaviour
{

    public GameObject Prefapplant;
    public AudioSource[] Souds;
    private bool CanPlant = true;
    private GameObject PrefapSprite;


     void OnMouseDown()
     {
         var spr = Resources.Load("Prefap/BG/Sprite", typeof(GameObject)) as GameObject;
        
        
        
        if (CanPlant && !GameManager.ShovelEnabled && GameManager.currentPlant == null 
            && GameManager.Cash >= Prefapplant.GetComponent<Propeities>().price)
        {
            Souds[0].Play();
            
            PrefapSprite = Instantiate(spr, transform.position, Quaternion.identity) as GameObject;
            
            
            GameManager.currenseed = gameObject;
            GameManager.currentPlant = Prefapplant;
            Debug.Log("d1");
                
        }
        // else if (!CanPlant || GameManager.Cash < Prefapplant.GetComponent<Propeities>().price)
        // {
        //     Souds[1].Play();
        //
        // }
        
            
        
    }


    
    void Update()
    {

        if (!CanPlant || GameManager.Cash < Prefapplant.GetComponent<Propeities>().price)
        {
            GetComponent<SpriteRenderer>().material.color = Color.gray;
            
        }
        else
        {
            GetComponent<SpriteRenderer>().material.color = Color.white;
        }

    }

    IEnumerator Waitime()
    {
        yield return new WaitForSeconds(Prefapplant.GetComponent<Propeities>().timerecharge);
        CanPlant = true;
    }

    public void StartRencharge()
    {
        CanPlant = false;
        GameManager.currenseed = null;
        StartCoroutine("Waitime");
        Destroy(PrefapSprite);
    }
}
