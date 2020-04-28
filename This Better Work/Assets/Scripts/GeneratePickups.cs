using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePickups : MonoBehaviour
{
    public GameObject Pickup;
    public int xPos;
    public int zPos;
    public float yPos;
    public int spawnTime;
    public int pCount;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Pickupdrop());
    }
    IEnumerator Pickupdrop()
    {
        while (pCount < 3)
        {
            xPos = Random.Range(20, 7);
            zPos = Random.Range(-16, 17);

            Instantiate(Pickup, new Vector3(xPos, 0, zPos), Quaternion.identity);
            yield return new WaitForSeconds(spawnTime);
            pCount += 1;
        }

    }
}
