using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerMotor : MonoBehaviour
{

    public float MaxHealth;

    [SerializeField]
    private float currentHealth;

    private Animator animator;

    public Slider healthSlider;
    public Text healthText;

    // Start is called before the first frame update
    void Start()
    {
        healthSlider.maxValue = MaxHealth;
        healthText.text = MaxHealth + "/" + MaxHealth;
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
