using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{

    public GameObject toSpawn;
    public float distanceToFly = 10;
    public float velocity = 0.1f;
    public float spawnRate = 1;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnCube", 3, spawnRate);
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnCube() {
        Vector3 spawnPos = new Vector3(0, 0, 0);
        Quaternion spawnRot = toSpawn.transform.rotation;
        GameObject cube = Instantiate(toSpawn, spawnPos, spawnRot) as GameObject;
        Flying flyingCube = cube.GetComponent<Flying>();
        flyingCube.distanceToFly = distanceToFly;
        flyingCube.velocity = velocity;
    }
}
