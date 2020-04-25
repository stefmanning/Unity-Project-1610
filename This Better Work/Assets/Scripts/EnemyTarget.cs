using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTarget : MonoBehaviour
{
    public Transform player;
    public float look;

    // locates player and follows player location /aggro
    void Update()
    {
        transform.LookAt(player);
        transform.Translate(Vector3.forward * look * Time.deltaTime);
        Debug.Log("Its looking at you");
    }
}
