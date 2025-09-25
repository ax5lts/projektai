using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike_Generator_bot : MonoBehaviour
{
    public GameObject spikePrefab;  
    public float spawnRate = 2f;      
    public float spawnX = 10f;       
        public float minY = -2f, maxY = 2f; 

    void Start()
    {
        InvokeRepeating(nameof(SpawnSpike), 1f, spawnRate);  
    }

    void SpawnSpike()
    {
        float randomY = Random.Range(minY, maxY);           
        Vector3 spawnPosition = new Vector3(spawnX, randomY, 0f);  

       
        Quaternion rotation = Quaternion.Euler(0, 0, 180f);

        Instantiate(spikePrefab, spawnPosition, rotation);  
    }
}

