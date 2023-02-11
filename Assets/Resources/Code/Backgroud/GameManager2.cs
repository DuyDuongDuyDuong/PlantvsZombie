using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager2 : MonoBehaviour
{
    public static GameManager2 instance;
    void Awake() { instance = this; }

    void Start()
    {
       

        StartCoroutine(WaveStartDelay());
    }

    IEnumerator WaveStartDelay()
    {
        yield return new WaitForSeconds(10f);
        GetComponent<EnemySpawner>().StartSpawning();
    }  
}
