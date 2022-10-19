using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objectToSpawn;

    private float spawnPosY = 0.5f;

    private float startDelay = 2.0f;
    //private float spawnInterval;
    private float targetTime;

    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("Instantiate(objectToSpawn, randomPosition, Quaternion.identity);", startDelay, spawnInterval);
        targetTime = 2;
    }
    private void Update()
    {
        targetTime -= Time.deltaTime;
        if (targetTime <= 0)
        {
            objectSpawn();
            targetTime = Random.Range(3, 6);
            //Debug.Log(targetTime);
        }
        Debug.Log(targetTime);

    }

    //void objectSpawn()
    //{
    //    Vector3 randomPosition = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
    //    Instantiate(objectToSpawn, randomPosition, Quaternion.identity);
    //}
    void objectSpawn()
    {
        Vector3 randomPosition = new Vector3(
        Random.Range(0, 2) == 0 ? Random.Range(-10, -100) : Random.Range(10, 100),

        spawnPosY,
        Random.Range(0, 2) == 0 ? Random.Range(-10, -100) : Random.Range(10, 100)
    );
        Instantiate(objectToSpawn, randomPosition, Quaternion.identity);
    }
    

    
    //Debug.Log(targetTime);
    //targetTime = 0;

}

