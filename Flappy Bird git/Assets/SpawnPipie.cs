using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPipie : MonoBehaviour
{
    public GameObject pipe;
    public Vector3 spawnPoint;
    public float timer;
    public float timeBetweenSpawns;
    public float randomY;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= timeBetweenSpawns)
        {
            SpawnObject();
            timer= 0;
        }
        
    }
    void SpawnObject()
    {
        float randomYaddToVector = RandomY();
        GameObject spawnedObject = Instantiate(pipe, new Vector3(spawnPoint.x, spawnPoint.y + randomYaddToVector, 0 ), Quaternion.identity);

    }
    float RandomY()
    {
        randomY = Random.Range(0, 100);
        randomY = randomY / 100;
        return randomY;
    }
}
