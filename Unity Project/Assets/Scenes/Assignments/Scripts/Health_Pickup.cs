using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_Pickup : Pickup
{
    public int healthAmt = 100;
   

    // Start is called before the first frame update
    void Start()
    {
        print("Player is health is " + healthAmt);
    }

    // Update is called once per frame
    void Update()
    {
        checkHealth();
        damageCheck();
    }

    void checkHealth ()
    {
        if (healthAmt == 100)
            staticVar.healthStatus = 5;
        if (healthAmt <= 99 && healthAmt >= 80)
            staticVar.healthStatus = 4;
        if (healthAmt <= 79 && healthAmt >= 60)
            staticVar.healthStatus = 3;
        if (healthAmt <= 59 && healthAmt >= 40)
            staticVar.healthStatus = 2;
        if (healthAmt <= 39)
            staticVar.healthStatus = 1;
    }
    public void damageCheck()
    {
       healthAmt  -= staticVar.enemydamage;
    }
    private void OnTriggerEnter(Collider other)
    {
        print("You gained  " + healthAmt+ " health!");
        Destroy(gameObject);
    }



}
