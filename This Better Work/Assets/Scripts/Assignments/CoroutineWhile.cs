using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineWhile : MonoBehaviour
{
    Coroutine LookAtCoroutine;

    public void StartLookAt()
    {
        if (LookAtCoroutine != null)
        {
            StopCoroutine(LookAtCoroutine);

        }
        LookAtCoroutine = StartCoroutine(LookAt());
    }

    IEnumerator LookAt()
    {
        var duration = Time.time + 4.0f;
        while (duration > Time.time)

        {

            print("the coroutine is working");
            yield return null;
        }
    }
}