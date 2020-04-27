using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpeed : MonoBehaviour
{
  
    private void OnTriggerEnter(Collider other)
    {

        speedIncrease();
    }

    void speedIncrease()
    {
        staticVar.poweredup = true;
        wait();
        
    }

    void speedDecrease()
    {
        staticVar.poweredup = true;
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(10);
        speedDecrease();
    }
}