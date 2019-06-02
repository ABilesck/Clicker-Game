using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerMotor : MonoBehaviour
{

    public float MaxHealth;
    public int enemyCount = 1;

    private float currentHealth;
    

    private Animator animator;
    private PlayerStats stats;

    public Slider healthSlider;
    public Text healthText;
    public GameObject GameOver;

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
    private void Update()
    {
        if(currentHealth <= 0)
        {
            Die();
        }
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

    private void Die()
    {
        GameOver.SetActive(true);
        Time.timeScale = 0;
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
