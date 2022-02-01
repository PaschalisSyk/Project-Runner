using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTile : MonoBehaviour
{
    GroundSpawner groundSpawner;
    public GameObject obstaclePrefab;
    public GameObject energyPrefab;

    float mixX = -3.5f;
    float maxX = 3.5f;

    void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();
    }

    private void OnTriggerExit(Collider other)
    {
        groundSpawner.SpawnTile(true);
        Destroy(gameObject, 1);
    }

    public void SpawnObstacle()
    {
        int obstaclesToSpawn = 2;

        for (int i = 0; i < obstaclesToSpawn; i++)
        {
            int obstacleSpawnIndex = Random.Range(2, 13);
            Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;

            Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
        
    }

    public void SpawnEnergy()
    {
        int energyToSpawn = 2;
        for (int i = 0; i < energyToSpawn; i++)
        {
            GameObject temp = Instantiate(energyPrefab,transform);
            temp.transform.position = GetRandomPoint(GetComponent<Collider>());
        }
    }

    Vector3 GetRandomPoint(Collider collider)
    {
        Vector3 point = new Vector3(Random.Range(mixX,maxX), 1
            , Random.Range(collider.bounds.min.z, collider.bounds.max.z));

        return point;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
