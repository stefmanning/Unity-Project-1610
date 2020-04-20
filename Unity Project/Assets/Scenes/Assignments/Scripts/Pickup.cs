using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public string pickupName;
    public string pickuptype;
    public int pointsToAdd;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            
            ScoreManger.AddPoints(pointsToAdd);
            Destroy(gameObject);
        }
    }



}
   