using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldSpawner : MonoBehaviour
{
    public GameObject EnviromentPref;
    Vector3 spawnpoint;


    public void SpawnEnviroment()
    {
        
            GameObject temp = Instantiate(EnviromentPref, spawnpoint, Quaternion.identity);
            spawnpoint = temp.transform.GetChild(0).transform.position;
    
    }

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            SpawnEnviroment();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
