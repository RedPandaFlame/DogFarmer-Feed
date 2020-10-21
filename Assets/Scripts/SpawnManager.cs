using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//PROTOTYPE 2

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefabs;
    private float spawnRangeX = 11;
    private float spawnPosZ = 15;
    private float startDelay = 2f;
    private float spawnInterval = 1.25f;

    private void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SpawnRandomAnimal();
        }
    }

    void SpawnRandomAnimal()
    {
     // Randomly generate animal index and spawn position
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        int animalIndex = Random.Range(0, animalPrefabs.Length);

        Instantiate(animalPrefabs[animalIndex],
        spawnPos,
        animalPrefabs[animalIndex].transform.rotation);
    }
}
