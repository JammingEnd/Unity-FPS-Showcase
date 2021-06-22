using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour, Idamageable
{
    [SerializeField] private EnemyStats enemyStats;
    [SerializeField] private Slider healthbarSlidar;
    [SerializeField] private Image healtbarFilling;
    [SerializeField] Color maxHealthColor;
    [SerializeField] Color noHealthColor;

    private int currentHealth;

    private void Start()
    {
        currentHealth = enemyStats.maxHealth;
        SetHealthbarUi();
    }

    public void DealDamage(int damage)
    {
        currentHealth -= damage;
        CheckIfDead();
        SetHealthbarUi();
    }

    private void CheckIfDead()
    {
        if(currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void SetHealthbarUi()
    {
        float healthPercentage = CalcHealth();
        healthbarSlidar.value = healthPercentage;
        healtbarFilling.color = Color.Lerp(noHealthColor, maxHealthColor, healthPercentage / 100);
    }
   private float CalcHealth()
    {
       return ((float)currentHealth / (float)enemyStats.maxHealth) * 100; 
    }

}  
