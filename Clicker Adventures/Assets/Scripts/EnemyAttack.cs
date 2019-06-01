using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public int dmg = 2;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("player"))
        {
            col.SendMessage("TakeDamage", dmg);
            Debug.Log(col.name);
        }
    }
}
