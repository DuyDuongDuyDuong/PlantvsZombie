using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class GrassInstance : MonoBehaviour
{
    public GameObject PrefapGass;
    private GameObject grass;
    private float currentX = -5.5418f, currentY = 2.9f, distanceX, distanceY;
    private bool newLine = true;

    private void Start()
    {
        distanceX = PrefapGass.GetComponent<SpriteRenderer>().bounds.size.x;
        distanceY = PrefapGass.GetComponent<SpriteRenderer>().bounds.size.y;

        for (int i = 0; i < 45; i++)
        {
            if (i % 9 == 0 && i != 0)
            {
                newLine = true;
                currentY = grass.transform.position.y - distanceY;
            }
            
            
            if (newLine)
            {
                newLine = false;
                grass = Instantiate(PrefapGass, new Vector2(-5.5418f, currentY), quaternion.identity) as GameObject;
            }
            else
            {
                grass = Instantiate(PrefapGass, new Vector2(currentX, currentY), quaternion.identity) as GameObject;
            }

            currentX = grass.transform.position.x + distanceX;
            grass.transform.SetParent(transform);
        }
    }
}
