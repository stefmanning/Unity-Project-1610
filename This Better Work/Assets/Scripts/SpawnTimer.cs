using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTimer : MonoBehaviour
{
    public GameObject enemy;
    float createRate = 15f, createRateTimer;
    float rateIncrease = 0.1f, initialCreateDelay = 3.0f;
    int callCounter = 0, callsBeforeRateIncrease = 10;

    void Start()
    {
        createRateTimer = createRate + initialCreateDelay;
    }

    void Update()
    {
        createRateTimer -= Time.deltaTime;
        if (createRateTimer <= 0)
        {
            CustomInvoke();
        }
    }

    void CustomInvoke()
    {
        Instantiate(enemy);
        callCounter++;
        if (callCounter >= callsBeforeRateIncrease)
        {
            createRate -= rateIncrease;
            callCounter = 0;
        }
        createRateTimer = createRate;
    }

}
