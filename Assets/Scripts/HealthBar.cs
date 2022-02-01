using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Text healthText;
    public Image healthbar;

    public float health;
    float maxHealth = 100;
    float lerpSpeed;

    int ShowHP;

    public StarterAssets.ThirdPersonController player;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        ShowHP = Mathf.RoundToInt(health);
        healthText.text = ShowHP.ToString();
        if (health > maxHealth)
        {
            health = maxHealth;
        }

        lerpSpeed = 3f * Time.deltaTime;

        HealthBarFiller();
        //ColorChanger();

        if (health > 0 && player.alive)
        {
            health -= 10f * Time.deltaTime;
        }

        if (health <=0 && player.alive)
        {
            player.Die();
            animator.SetBool("OutOfEnergy" , true);
        }
        if(!player.alive)
        {
            health = 0;
        }
    }

    void HealthBarFiller()
    {
        healthbar.fillAmount = Mathf.Lerp(healthbar.fillAmount, health / maxHealth, lerpSpeed);
    }

    public void Heal()
    {
        if (health < maxHealth)
        {
            health += 20;
            if (health > maxHealth)
            {
                health = maxHealth;
            }
        }
    }
    void ColorChanger()
    {

       if (health < 25)
       {
            Color healthColor = Color.Lerp(healthbar.GetComponent<Image>().color,Color.red, lerpSpeed);
            healthbar.color = healthColor;
       }

    }

}
