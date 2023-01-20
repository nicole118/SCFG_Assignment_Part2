using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public Slider slider;
    public int currentHealth;
    int _maxHealth = 100;
    
    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    public void SetHealth(int health)
    {
        slider.value = health;
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
        SetHealth(currentHealth);

        if (currentHealth <= 0)
        {
            SceneManager.LoadScene(5);
        }
    }
}
