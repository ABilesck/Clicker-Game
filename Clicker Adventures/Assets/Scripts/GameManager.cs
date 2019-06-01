using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject currentEnemy;
    [SerializeField]
    private GameObject[] enemies;
    [SerializeField]
    private GameObject enemySpawn;

    // Start is called before the first frame update
    void Start()
    {
        //enemies = Resources.LoadAll<GameObject>("Enemies");
        enemySpawn = GameObject.FindGameObjectWithTag("enemySpawn");
    }

    // Update is called once per frame
    void Update()
    {
        currentEnemy = GameObject.FindGameObjectWithTag("enemy");

        if(currentEnemy == null)
        {
            int randomIndex = Random.Range(0, enemies.Length - 1);
            Instantiate(enemies[randomIndex], 
                enemySpawn.transform.position,
                enemySpawn.transform.rotation);

            currentEnemy = enemies[randomIndex];

        }
    }
}
