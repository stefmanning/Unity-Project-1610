using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIhealth : MonoBehaviour
{
    public float maxHealth;
    public float spawnHealth;
    public float aiHealth;
    public int pointsToAdd;

    public bool regeneratingHealth;
    public bool regeneratingShields;
    public float healthRegen;

    public bool justGotHit;

    public GameObject healthEffect;

    void Update()
    {
        justGotHit = false;
        if (aiHealth <= 0)
        {
            Destroy(gameObject);
            ScoreManager.AddPoints(pointsToAdd);
        }

    }
}