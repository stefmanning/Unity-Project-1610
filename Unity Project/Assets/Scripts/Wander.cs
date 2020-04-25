using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wander : Monobehaviour

{
    public float wanderRadius;

    public float wanderTimer;

    private transform target;
    private NavMeshAgent agent;
    private float timer;
    public float alterDist;
    public float attackDist;
    private float distance;
    private Vector3 heading;
    public float speed;
    //attack
    public int damage;

    void OnEnable()
    {
        agent = GetComponent<NavMeshAgent>();
        timer = wanderTimer;
    }
    void Start()
    {
        distance = Vector3.Distance(target.position, transform.position);
    }

    void Update()
    { //alert
        distance = Vector3.Distance(target.position, transform.position);
        if (distance < alertDist && distance > attackDist)
        {
            print("Enemy sees target");
            speed += 2;
            transform.LookAt(target);
            transform.Translate(Vector3.forward * speed * timer.deltaTime);
        }
        //following
        else if (distance <= alertDist)
        {
            print("Enemy is Following");
            heading = target.position - transform.position;
            heading.y = 0;
            speed += 5;
            transform.LookAt(target);
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

            if (heading.magnitude <= attackDist)
            {
                print("Enemy is attacking");
                var health = target.gameObject.GetComponent<PlayerHealth>();


                if (health != null)
                {
                    health.TakeDamage(damage);

                }
            }
        }
        //wandering



    }

}