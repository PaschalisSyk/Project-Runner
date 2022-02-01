using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnviromentTile : MonoBehaviour
{
    FieldSpawner fieldSpawner;
    // Start is called before the first frame update
    void Start()
    {
        fieldSpawner = GameObject.FindObjectOfType<FieldSpawner>();
    }

    private void OnTriggerExit(Collider other)
    {
        fieldSpawner.SpawnEnviroment();
        Destroy(gameObject, 5);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
