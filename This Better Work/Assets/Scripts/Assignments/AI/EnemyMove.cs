using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{

    //public GameObject player;
    public Transform target; //used for transform.translate
    public int damage;
    public float moveSpeed;
    public int enemyHealth;
    public int pointsToAdd;
    public int damageTaken;
    public int spawnHealth;
    public float lifetime;

    public bool isRanged;
    public float playerProximity;
    public float sightRange;
    public float enemyRange;
    public float enemyCooldown;
    public float enemyRof;
  

    void Start()
    {
        //enemyRb = GetComponent<Rigidbody>();
        //player = GameObject.Find("Player");
        enemyHealth = spawnHealth;
    
    }

    // Update is called once per frame
    void Update()
    {
        lifetime += Time.deltaTime;

        if (playerProximity < sightRange)
        {
            transform.LookAt(target);
            target = GameObject.FindWithTag("Player").transform;

        }


        target = GameObject.FindWithTag("Player").transform;

        enemyCooldown += Time.deltaTime;

        //measures the object's distance from player
        playerProximity = Vector3.Distance(target.position, transform.position);
        if (playerProximity > enemyRange && playerProximity < sightRange)
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        }
        if (enemyHealth < 1)
        {
            Destroy(gameObject);
            ScoreManager.AddPoints(pointsToAdd);

        }

        
        if (playerProximity > 100)
        {
            Destroy(gameObject);

        }
    }

    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.CompareTag("Bullet"))
        {
            //enemyHealth -= 25;

        }

    }

    public void TakeDamage(int damage)
    {
        enemyHealth -= damage;

    }

}