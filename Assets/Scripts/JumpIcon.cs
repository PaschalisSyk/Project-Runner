using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JumpIcon : MonoBehaviour
{
    public StarterAssets.ThirdPersonController player;

    public float jumpValue;
    float maxJumpValue = 1;
    float lerpSpeed;

    // Start is called before the first frame update
    void Start()
    {
        jumpValue = player._jumpTimeoutDelta;
    }

    // Update is called once per frame
    void Update()
    {
        if ( jumpValue > maxJumpValue)
        {
            jumpValue = maxJumpValue;
        }

        lerpSpeed = 3f * Time.deltaTime;
        Fill();
    }

    public void Fill()
    {
        //jumpImg.fillAmount = Mathf.Lerp(jumpImg.fillAmount, maxJumpValue, lerpSpeed);
        Debug.Log("fill");
    }
}
