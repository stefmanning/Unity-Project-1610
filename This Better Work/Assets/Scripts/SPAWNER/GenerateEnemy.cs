﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemy : MonoBehaviour
{
    public GameObject Enemy;
    public int xPos;
    public int zPos;
    public float yPos;

    public int enemyCount;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Enemydrop());
    }
        IEnumerator Enemydrop()
    {
        while (enemyCount < 10)
        {
            xPos = Random.Range(20, 7);
            zPos = Random.Range(-16, 17);
            yPos = Random.Range(-2.6f, -1.3f);
            Instantiate(Enemy, new Vector3(xPos, 0, zPos), Quaternion.identity);
            yield return new WaitForSeconds(10);
            enemyCount += 1;
        }
    }
}
