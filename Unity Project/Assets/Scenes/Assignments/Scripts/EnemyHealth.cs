using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int currentHealth;
    public const maxHealth = 3;
    public Transform spawnPoint;
    public int points;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    
    // Update is called once per frame
    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <=0)
        {
            //keep score at zero
            currentHealth = 0;
            print("Enemy is Dead!");
            //add points to score for killing enemy
            //scoreManager.AddPoints(points)
            //Move enemy to spawn point for restart
            transform.position = spawnPoint.position;
            transform.rotation = spawnPoint.rotation;
            //reset enemy Health
            currentHealth = maxHealth;

        }
    }
}
