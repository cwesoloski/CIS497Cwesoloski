using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //Set array of Refreneces
    public GameObject[] animalsToSpawn;

    private float leftBound = -14;
    private float rightBoud = 14;
    private float spawnPosZ = 25;

    public HealthSystem healthSystem;


    private void Start()
    {
        //get a reference to the health system script
        healthSystem = GameObject.FindGameObjectWithTag("Health System").GetComponent<HealthSystem>();

        StartCoroutine(SpawnRandomAnimalWithCoroutine());
    }

    IEnumerator SpawnRandomAnimalWithCoroutine()
    {
        // add three second delay before first spawning objects
        yield return new WaitForSeconds(3f);

        while (!healthSystem.gameOver)
        {
            float randomDelay = Random.Range(0.8f, 2.0f);

            SpawnRandomAnimal();
            yield return new WaitForSeconds(randomDelay);
        }
    }

    void SpawnRandomAnimal()
    {
        //pick a random animal
        int animalIndex = Random.Range(0, animalsToSpawn.Length);

        //generate a random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(leftBound, rightBoud), 0 , spawnPosZ);

        Instantiate(animalsToSpawn[animalIndex], spawnPos, animalsToSpawn[animalIndex].transform.rotation);
    }
}
