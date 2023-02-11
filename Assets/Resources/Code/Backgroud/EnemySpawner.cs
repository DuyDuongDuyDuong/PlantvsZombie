using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;
using System.Collections.Generic;

public class EnemySpawner : MonoBehaviour
{
    // public static EnemySpawner instance;
    // void Awake(){instance=this;}
    //
    // public GameObject[] prefabs;
    // public Transform[] spawnPoints;
    // public float spawnInterval = 2f;
    //
    //
    // public void StartSpawning()
    // {
    //     StartCoroutine(SpawnDelay());
    // }
    //
    // IEnumerator SpawnDelay()
    // {
    //     SpawnEnemy();
    //     yield return new WaitForSeconds(10f);
    //     StartCoroutine(SpawnDelay());
    // }
    //
    // void SpawnEnemy()
    // {
    //    
    //     int randomPrefabID = Random.Range(0,prefabs.Length);
    //     int randomSpawnPointID = Random.Range(0, spawnPoints.Length);
    //     Instantiate(prefabs[randomPrefabID], spawnPoints[randomSpawnPointID].position, transform.rotation);
    // }

    
    
    
    public static EnemySpawner instance;
    void Awake(){instance=this;}
    
    public GameObject[] prefabs;
    public Transform[] spawnPoints;
    public float spawnInterval = 2f;
    
    
    public void StartSpawning()
    {
        StartCoroutine(SpawnDelay());
    }
    
    IEnumerator SpawnDelay()
    {
        SpawnEnemy();
        yield return new WaitForSeconds(200f);
        StartCoroutine(SpawnDelay());
    }
    
    void SpawnEnemy()
    {
       
        int randomPrefabID = Random.Range(0,prefabs.Length);
        int randomSpawnPointID = Random.Range(0, spawnPoints.Length);
        Instantiate(prefabs[randomPrefabID], spawnPoints[randomSpawnPointID].position, transform.rotation);
    }

    
    
    
   
}
