using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class SunFllow : MonoBehaviour
{
    public GameObject FrefapSunfllow;
    
    void Start()
    {
        InvokeRepeating("instantiatesun", 5, 20);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void instantiatesun()
    {
        var temp = Instantiate(FrefapSunfllow, transform.position, quaternion.identity) as GameObject;
        temp.GetComponent<Sun>().newInstace = true;
        


    }
}
