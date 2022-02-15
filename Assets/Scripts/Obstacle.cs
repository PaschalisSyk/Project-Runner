using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    StarterAssets.ThirdPersonController playerMovement;
    public GameObject collisionParticles;

    // Start is called before the first frame update
    void Start()
    {
        playerMovement = GameObject.FindObjectOfType<StarterAssets.ThirdPersonController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            CollisionParticles(other);
            playerMovement.Die();
        }
    }

    private void CollisionParticles(Collider other)
    {
        Vector3 spawnPos = other.gameObject.GetComponent<Collider>().ClosestPointOnBounds(transform.position);

        Instantiate(collisionParticles, spawnPos, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
