using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] EnemySpawn enemySpawn;
    [SerializeField] GameObject spawnPoint;
    [SerializeField] Enemy enemy;

    float spawnTime;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CreateEnemies());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator CreateEnemies()
    {
        Vector3 pos = new Vector3(spawnPoint.transform.position.x, spawnPoint.transform.position.y, spawnPoint.transform.position.z);
        while (true)
        {
            spawnTime = Random.Range(1f, 3f);
            yield return new WaitForSeconds(spawnTime);
            var nee=Instantiate(enemy,
                        pos,
                        enemy.transform.rotation);
            enemySpawn.SetStartingParameters();
            enemySpawn.Coroutine(nee);
            //yield return new WaitForSeconds(spawnTime);
        }
    }
}
