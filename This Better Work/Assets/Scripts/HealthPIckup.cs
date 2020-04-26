using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPIckup : MonoBehaviour
{
    public int healthAmt = 50;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        //Destroy(gameObject);
        Move.AddHealth(healthAmt);
    }
    /*private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            Destroy(gameObject);
            

        }


    }*/
}