using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public Text enemyCountText;

    public playerMotor player;
    private GameObject currentEnemy;

    public GameObject[] enemies;
    private GameObject enemySpawn;
    
    private int enemyCount = 1;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("player").GetComponent<playerMotor>();
    }

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

        enemyCountText.text = enemyCount.ToString();

        if (currentEnemy == null)
        {

            if (enemyCount % 10 != 0)
            {
                int randomIndex = Random.Range(0, enemies.Length - 1);
                Instantiate(enemies[randomIndex],
                    enemySpawn.transform.position,
                    enemySpawn.transform.rotation);

                currentEnemy = enemies[randomIndex];
            }
            else if(enemyCount % 10 == 0)
            {
                Debug.Log("Boss");
            }

        }

        

        if (player != null)
            enemyCount = player.enemyCount;


    }
}
