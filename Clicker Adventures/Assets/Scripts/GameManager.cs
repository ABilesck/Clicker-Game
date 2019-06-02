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

    [SerializeField]
    private int enemyCount = 0;

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

        if(currentEnemy == null)
        {
            int randomIndex = Random.Range(0, enemies.Length - 1);
            Instantiate(enemies[randomIndex], 
                enemySpawn.transform.position,
                enemySpawn.transform.rotation);

            currentEnemy = enemies[randomIndex];

        }

        if (player != null)
            enemyCount = player.enemyCount;

        enemyCountText.text = enemyCount.ToString();

    }
}
