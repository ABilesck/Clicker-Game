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
    }

    public void Attack()
    {
        animator.SetTrigger("isAttacking");
    }

    public void TakeDamage(int Damage)
    {
        currentHealth -= Damage;
        Debug.Log("We were hit");
        updateHealth();
    }

    void updateHealth()
    {
        healthSlider.value = currentHealth;
        healthText.text = currentHealth + "/" + MaxHealth;
    }

}
