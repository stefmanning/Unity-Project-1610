using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public int enemyIndex;
    public Transform[] spawnPoints;


    public int startSpawnTime = 10;
    public int spawnTime = 5;

    // Start is called before the first frame update
    void Start()
    {
        // Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
        InvokeRepeating("Spawn", startSpawnTime, spawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        int enemyIndex = Random.Range(0, enemyPrefabs.Length);

        if (Input.GetKeyDown(KeyCode.E))

        {

            Instantiate(enemyPrefabs[enemyIndex], new Vector3(0, 0, 0), enemyPrefabs[enemyIndex].transform.rotation);
        }
    }
    void Spawn()
    {
        // Find a random index between zero and one less than the number of spawn points.
        int spawnPoints = Random.Range(0, 5);

    }
}