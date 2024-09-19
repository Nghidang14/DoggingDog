using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{

    public GameObject obstacle;
    public float spawnRate;
    public float maxPosX;

    // Start is called before the first frame update
    void Start()
    {
        StartSpawning();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Spawn()
    {
        float randomX = Random.Range(-maxPosX, maxPosX);
        Vector2 spawnPos = new Vector2(randomX, transform.position.y);

        Instantiate(obstacle, spawnPos, Quaternion.identity);
    }

    private void StartSpawning()
    {
        InvokeRepeating("Spawn", 1f, spawnRate);
    }

    public void StopSpawning()
    {
        CancelInvoke("Spawn");
    }
}
