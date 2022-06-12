using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] enemyPatterns;
    /* public GameObject[] enemy2Patterns;
     public GameObject[] enemy3Patterns;
     public GameObject[] heartPatterns;
     public GameObject[] coinPatterns;
     */

    public float maxX, maxY, distance;

    private float timeBtwSpawn;
    public float startTimeBtwSpawn;
    public float decreaseTime;
    public float minTime;

    public Player player;

    private void Update()
    {
        timeBtwSpawn -= Time.deltaTime;
        while (timeBtwSpawn <= 0)
        {
            Vector3 EnemyPosition = new Vector3(Random.Range(-maxX, maxX), Random.Range(-maxY, maxY), 0);
            if ((EnemyPosition - transform.position).magnitude < distance)
            {
                continue;
            }
            else
            {
                int rand = Random.Range(0, enemyPatterns.Length);
                Instantiate(enemyPatterns[rand], EnemyPosition, Quaternion.identity);
            }

            timeBtwSpawn = startTimeBtwSpawn;

            /*if (character.score < 30)
            {
            int rand = Random.Range(0, enemyPatterns.Length);
                Instantiate(enemyPatterns[rand], transform.position, Quaternion.identity);
            }
            else
            {
                int rand1 = Random.Range(0, 1000);
                if (rand1 < 80)
                {
                    int rand = Random.Range(0, heartPatterns.Length);
                    Instantiate(heartPatterns[rand], transform.position, Quaternion.identity);
                }

                else if (rand1 < 200)
                {
                    int rand = Random.Range(0, coinPatterns.Length);
                    Instantiate(coinPatterns[rand], transform.position, Quaternion.identity);
                }

                else
                {
                    if (character.score < 100)
                    {
                        int rand = Random.Range(0, enemyPatterns.Length);
                        Instantiate(enemyPatterns[rand], transform.position, Quaternion.identity);
                    }
                    else if (character.score < 300)
                    {
                        int rand = Random.Range(0, enemy2Patterns.Length);
                        Instantiate(enemy2Patterns[rand], transform.position, Quaternion.identity);
                    }
                    else
                    {
                        int rand = Random.Range(0, enemy3Patterns.Length);
                        Instantiate(enemy3Patterns[rand], transform.position, Quaternion.identity);
                    }

                }
            }
            
            if (startTimeBtwSpawn > minTime)
            {
                startTimeBtwSpawn -= decreaseTime;
            }
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }*/
        }
    }
}
