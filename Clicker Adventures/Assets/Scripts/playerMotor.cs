using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerMotor : MonoBehaviour
{

    public float MaxHealth;
    public int enemyCount = 0;

    private float currentHealth;
    

    private Animator animator;
    private PlayerStats stats;

    public Slider healthSlider;
    public Text healthText;

    private void Awake()
    {
        healthSlider.maxValue = MaxHealth;
        healthText.text = MaxHealth + "/" + MaxHealth;
    }
    
    void Start()
    {
        currentHealth = MaxHealth;
        animator = GetComponent<Animator>();
        stats = GetComponent<PlayerStats>();
    }

    public void Attack()
    {
        animator.SetTrigger("isAttacking");
    }

    public void TakeDamage(int Damage)
    {
        currentHealth -= Damage;
        updateHealth();
    }

    void updateHealth()
    {
        healthSlider.value = currentHealth;
        healthText.text = currentHealth + "/" + MaxHealth;
    }

    private void AddExp(float exp)
    {
        stats.Exp += exp;
    }

    private void AddGold(int gold)
    {
        stats.Gold += gold;
    }

}
