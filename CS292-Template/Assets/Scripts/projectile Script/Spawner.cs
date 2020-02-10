using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform[] SpawnPoint;
    public GameObject[] projectile;

    private float timeBtwSpawns;
    public float startTimeBtwSpawns;
    
    public float minTimeBetweenSpawns;
    public float decrease;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timeBtwSpawns <= 0){
            Transform randomSpawnPoint = SpawnPoint[Random.Range(0, SpawnPoint.Length)];
            GameObject randomProjectile = projectile[Random.Range(0, projectile.Length)];

            Instantiate(randomProjectile, randomSpawnPoint.position, Quaternion.identity);
            
            if(startTimeBtwSpawns > minTimeBetweenSpawns){
                startTimeBtwSpawns -= decrease;
            }

            timeBtwSpawns = startTimeBtwSpawns;
        }
        else {
            timeBtwSpawns -= Time.deltaTime;
        }
    }
}
