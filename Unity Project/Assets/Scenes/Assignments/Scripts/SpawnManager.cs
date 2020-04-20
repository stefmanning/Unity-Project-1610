using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefab;
    public int enemyIndex;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int enemyIndex = Random.Range(0, enemyPrefab.Length);

        if (Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(enemyPrefab[enemyIndex], new Vector3(0, 0, 0), enemyPrefab[enemyIndex].transform.rotation);
        }

    }
}
