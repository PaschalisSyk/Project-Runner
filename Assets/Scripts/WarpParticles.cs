using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WarpParticles : MonoBehaviour
{
    Vector3 startPos;
    ParticleSystem ps;
    StarterAssets.ThirdPersonController player;
    // Start is called before the first frame update
    void Start()
    {
        ps = GetComponentInChildren<ParticleSystem>();
        startPos = new Vector3(0, -5, 0);
        transform.position = startPos;
        player = FindObjectOfType<StarterAssets.ThirdPersonController>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position += Vector3.forward * player._speed * Time.deltaTime;
        PlayParticles();
    }
    void PlayParticles()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            ps.Play();
        }
        else
        {
            ps.Stop();
        }
    }
}
