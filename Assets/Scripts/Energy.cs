using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Energy : MonoBehaviour
{
    HealthBar health;

    private void OnTriggerEnter(Collider other)
    {
        if ( other.gameObject.name != "Player")
        {
            return;
        }

        Destroy(gameObject);
        health.Heal();
    }
    // Start is called before the first frame update
    void Start()
    {
        health = GameObject.FindObjectOfType<HealthBar>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
