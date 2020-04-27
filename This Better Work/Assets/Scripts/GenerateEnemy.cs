using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemy : MonoBehaviour
{
    public GameObject Enemy;
    public int xPos;
    public int zPos;
    public float yPos;
    public int spawnTime;
    public int enemyCount;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Enemydrop());
    }
        IEnumerator Enemydrop()
    {
        while (enemyCount < 10)
        {
            xPos = Random.Range(20, 7);
            zPos = Random.Range(-16, 17);
           
            Instantiate(Enemy, new Vector3(xPos, 0, zPos), Quaternion.identity);
            yield return new WaitForSeconds(spawnTime);
            enemyCount += 1;
        }

    }
}
