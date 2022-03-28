using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject collectable;

    float ranX;
    float ranY;
    float ranZ;

    Vector3 spawnPoint;

    public float spawnRate;
    public float nextSpawn;

    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            ranX = Random.Range(-4f, 4f);
            ranY = 0.75f;
            ranZ = Random.Range(-950f, -550f);

            spawnPoint = new Vector3(ranX, ranY, ranZ);

            Instantiate(collectable, spawnPoint, Quaternion.identity);
        }
    }
}
