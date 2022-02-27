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
    public Gradient gradient;
    public Animator animator;

    Score score;
    // Start is called before the first frame update
    void Start()
    {
        score = FindObjectOfType<Score>();
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
        ColorChanger();

        if (health > 0 && player.alive)
        {
            health -= 10f * Time.deltaTime;
        }

        if (health <=0 && player.alive)
        {
            player.Die();
            animator.SetBool("OutOfEnergy", true);
        }
        if(!player.alive)
        {
            health = 0;
        }

    }

    public void HealthBarFiller()
    {
        healthbar.fillAmount = Mathf.Lerp(healthbar.fillAmount, health / maxHealth, lerpSpeed);
    }

    public void Heal()
    {
        if (health < maxHealth)
        {
            score.score += 50;
            health += 20;
            if (health > maxHealth)
            {
                health = maxHealth;
            }
        }
    }
    void ColorChanger()
    {
        healthbar.color = Healthbar1(health/100);
    }

    Color Healthbar1(float healthvalue)
    {
        return gradient.Evaluate(healthvalue);
    }

}
