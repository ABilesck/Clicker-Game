using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMotor : MonoBehaviour
{
    public float MaxHealth = 10f;
    public int BaseDamage;
    public float attackTime = 3f;

    public float timesStamp = 2f;

    private playerMotor player;

    [SerializeField]
    private float currentHealth;
    private Animator animator;

    public bool isOnGround;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("player").GetComponent<playerMotor>();
        currentHealth = MaxHealth;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }

        if(Time.time >= timesStamp && isOnGround)
        {
            animator.SetTrigger("isAttacking");
            timesStamp = Time.time + attackTime;
            //player.TakeDamage(BaseDamage);
        }
    }

    public void TakeDamage(int Damage)
    {
        currentHealth -= Damage;
        Debug.Log("we hit " + gameObject.name +" - "+ Damage);
    }

    public void Grounded()
    {
        isOnGround = true;
    }
}
