using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{

    public Rigidbody bullet;
    public Transform bulletspawn;
    public int Speed;

    void Update()
    {
        
        if (Input.GetKey(KeyCode.F))
        {

            Rigidbody clone;

            clone = (Rigidbody)Instantiate(bullet, bulletspawn.position, bullet.rotation);

            clone.velocity = bulletspawn.TransformDirection(Vector3.forward * Speed);
        }
    }
}