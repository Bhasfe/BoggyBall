using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{

    [Range(0f, 10f)] [SerializeField] float gameSpeed = 1f;
    [SerializeField] float movementSpeed;
    [SerializeField] int numberOfEnemies;
    [SerializeField] float timeBetweenSpawns;
    [SerializeField] Enemy enemy;
    int score = 0;
    [SerializeField] TextMeshProUGUI scoreText;
    //[SerializeField] float score;
    // Start is called before the first frame update
    public  float GetMovementSpeed()
    {
        return movementSpeed;
    }

    public int GetNumberOfEnemies()
    {
        return numberOfEnemies;
    }
    public float GetTimeBetweenSpawns()
    {
        return timeBetweenSpawns;
    }
    public Enemy GetEnemy()
    {
        return enemy;
    }



    



    void Start()
    {
        scoreText.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = gameSpeed;
    }

    public void AddScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

    public int GetScore()
    {
        return score;
    }
}
