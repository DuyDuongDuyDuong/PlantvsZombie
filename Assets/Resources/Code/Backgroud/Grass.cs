using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grass : MonoBehaviour
{
   private bool isEmpty;

   private void Update()
   {
      RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up, 0.1f, LayerMask.GetMask("Plant"));
      isEmpty = hit.collider == null;
      
   }

   private void OnMouseDown()
   {
      if (isEmpty && GameManager.currentPlant != null)
      {
         Instantiate(GameManager.currentPlant, transform.position, Quaternion.identity);
         GameManager.Cash -= GameManager.currentPlant.GetComponent<Propeities>().price;
         GameManager.currentPlant = null;
         GameManager.currenseed.GetComponent<SeedScrip>().StartRencharge();
      }
   }
}
