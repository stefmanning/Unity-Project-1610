using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public GameObject player;
    public Transform target;
    public int damage;
    public float moveSpeed;




    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        staticVar.enemydamage = 0;
        damage = 5;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }

    private void OnTriggerStay(Collider other)
    {
        damagePlayer();
    }

    public void damagePlayer()
    {
        staticVar.enemydamage = damage;
    }

}
