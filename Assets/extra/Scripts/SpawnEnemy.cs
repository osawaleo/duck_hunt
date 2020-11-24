using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject theEnemy;
    float spawnTime = 3;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemyDrop());
    }
    IEnumerator EnemyDrop()
    {
       while (true)
        {
            int xPos;
            int zPos;
            int i = Random.Range(0, 4);
            if (i == 0)
            {
                xPos = Random.Range(-10, 10);
                zPos = Random.Range(5, 10);
            }
            else
            {
                if (i == 1)
                {
                    xPos = Random.Range(-10, 10);
                    zPos = Random.Range(-5, -10);
                }
                else
                {
                    if (i == 2)
                    {
                        xPos = Random.Range(5, 10);
                        zPos = Random.Range(10, -10);
                    }
                    else
                    {
                        xPos = Random.Range(-5, -10);
                        zPos = Random.Range(10, -10);
                    }
                }
            }

            Instantiate(theEnemy, new Vector3(xPos, 1, zPos), Quaternion.identity);
            yield return new WaitForSeconds(spawnTime);
            spawnTime -= 0.01f;
        }
    }
    // Update is called once per frame
    IEnumerator Spawn()
    {
        int xPos;
        int zPos;
        int i = Random.Range(0, 4);
        if (i == 0)
        {
            xPos = Random.Range(-10, 10);
            zPos = Random.Range(5, 10);
        }
        else
        {
            if (i == 1)
            {
                xPos = Random.Range(-10, 10);
                zPos = Random.Range(-5, -10);
            }
            else
            {
                if (i == 2)
                {
                    xPos = Random.Range(5, 10);
                    zPos = Random.Range(10, -10);
                }
                else
                {
                    xPos = Random.Range(-5, -10);
                    zPos = Random.Range(10, -10);
                }
            }
        }

        Instantiate(theEnemy, new Vector3(xPos, 1, zPos), Quaternion.identity);
        yield return new WaitForSeconds(spawnTime);
        spawnTime -= 0.01f;
    }

    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Target").Length == 0)
        {
            this.Spawn();
        }
    }
}
