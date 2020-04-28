using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{

    public int pointsToAdd;
    public float timeToDie;
    public GameObject Pickups;


    // Start is called before the first frame update

    void OnTriggerEnter(Collider other)
    {
        Move.boostOn();
        Pickups.SetActive(false);
        Invoke("powerDown", 5);

    }

    void powerDown()
    {
        Move.boostOff();
        //Invoke("Respawn", Random.Range(1,15));
        Destroy(gameObject);
    }
     void Respawn()
        {
        Pickups.SetActive(true);
        
        }



        //Destroy(gameObject);
    }
    /*void OnTriggerEnter(Collider Other)
    {
        if (Other.gameObject.CompareTag("Player"))
        {
            ScoreManager.AddPoints(pointsToAdd);
            Destroy(gameObject);

        }*/



