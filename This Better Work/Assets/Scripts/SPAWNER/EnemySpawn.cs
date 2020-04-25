using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemy;
    public Transform enemyPos;
    public float repeatRate = 5.0f;

   
    void OnTriggerEnter(Collider other)
    {
      
        InvokeRepeating("EnemySpawner", 0.5f, repeatRate);
        Destroy(gameObject, 11);
        gameObject.GetComponent<BoxCollider>().enabled = false;

    }
    void EnemySpawner()

    {
        Instantiate(enemy, enemyPos.position, enemyPos.rotation);
    }

}
