using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameController gameController;
    Enemy enemy;
    Enemy[] enemies;
    int numberOfEnemies;
    float timeBetweenSpawns;
    void Start()
    {
        //SetStartingParameters();
       // StartCoroutine(Spawn(enemy));
    }

    public void SetStartingParameters()
    {
        numberOfEnemies = gameController.GetNumberOfEnemies();
        timeBetweenSpawns = gameController.GetTimeBetweenSpawns();
        enemy = gameController.GetEnemy();
    }

    public void Coroutine(Enemy enemy)
    {
        StartCoroutine(Spawn(enemy));
    }

    public IEnumerator Spawn(Enemy enemy)
    {
        Enemy[] enemies = new Enemy[numberOfEnemies];
        //toplari olusturdum
        for (int enemyCount = 0; enemyCount < numberOfEnemies; enemyCount++)
        {
            enemies[enemyCount] = Instantiate(enemy,
                                              enemy.transform.position,
                                              enemy.transform.rotation);
        }
        //ilkine sonra hepsine yon atamasi atamasi
        enemy.MakeEnemyRotate();
        for (int enemyCount = 0; enemyCount < numberOfEnemies; enemyCount++)
        {
            enemies[enemyCount].transform.rotation = enemy.transform.rotation;
        }
        enemy.MakeEnemyMove();
        yield return new WaitForSeconds(timeBetweenSpawns);
        enemies[0].GetComponent<Rigidbody2D>().velocity = enemy.GetComponent<Rigidbody2D>().velocity;
        //sirayla hepsini harekete gecirme
        for (int enemyCount = 1; enemyCount < numberOfEnemies; enemyCount++)
        {
            yield return new WaitForSeconds(timeBetweenSpawns);
            enemies[enemyCount].GetComponent<Rigidbody2D>().velocity = enemies[enemyCount-1].GetComponent<Rigidbody2D>().velocity;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
