using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Text;
using ChartboostSDK;

public class Ball : MonoBehaviour
{
    [SerializeField] GameObject SpawnPoint;
    [SerializeField] GameObject EnemySpawn;
    [SerializeField] GameObject Enemy;
    [SerializeField] GameController gameController;
    [SerializeField]  public int health;
    [SerializeField] float movementSpeed;
    [SerializeField] AudioClip ballSound;
    
    AudioSource myAudioSource;
    //Bhasfe
    private sceneManager GameSceneManager;

    Vector2 speed = new Vector2(0f, 200f);
    Vector2 limit = new Vector2(0f, 1f);
    // Start is called before the first frame update

    private void Start()
    {
        myAudioSource = GetComponent<AudioSource>();
        SpawnPoint.SetActive(true);
        //EnemySpawn.SetActive(true);
        Enemy.SetActive(true);
        health = 1;
        // Bhasfe
        GameSceneManager = GameObject.FindObjectOfType<sceneManager>();

    }

    
    void Update()
    {
        //Gravity();
        //ControlSpeed();
        Move();
        StartCoroutine(CheckIfAlive());
    }

    public void SetScore()
    {
        int score;
        score = gameController.GetScore();
        PlayerPrefs.SetFloat("Player Score", score);
        
    }

    public float GetScore()
    {
        float x = PlayerPrefs.GetFloat("Player Score");
        return x;
    }

    IEnumerator CheckIfAlive()
    {
        if (health <= 0)
        {
            // Bhasfe
            yield return new WaitForEndOfFrame();
            GameOver();


            /*
            SpawnPoint.SetActive(false);
            //EnemySpawn.SetActive(false);
            //Enemy.SetActive(false);
            //Destroy(Enemy);
            GameObject[] allObjects = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject obj in allObjects)
            {
                obj.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            }
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            yield return new WaitForSeconds(3);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            */
        }
    }



    public void GameOver()
    {
        SetScore();
        //UnityAdManager.instance.ShowAd();
        ChartManager.instance.ShowInter();

        GameSceneManager.NextScene();
    }

    private void Gravity()
    {
        
        Vector2 force = new Vector2(0, -3f);
        GetComponent<Rigidbody2D>().AddForce(force);
    }

    private void Move()
        //hareketi sagliyor
    {

        if (Input.GetMouseButtonDown(0))
        {
            //TouchingPhase();
        }

            if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);


            switch (touch.phase)
            {
                //dokunmaya baslayinca belli araliklarla surekli hizi arttiriyor
                case TouchPhase.Began:
                    {
                        TouchingPhase();

                    }

                    break;

                //dokunmayi birakinca fonksiyonu sonlandiriyor
                case TouchPhase.Ended:
                    //CancelInvoke();
                    break;
            }
        }
    }

    private void TouchingPhase()
    {
        myAudioSource.PlayOneShot(ballSound);
        //InvokeRepeating("SpeedUp", 0f, 0.3f);
        Invoke("SpeedUp",0);
    }

    private void ControlSpeed()
    {
        //hizi belli bi yerde sabitliyor
        if (GetComponent<Rigidbody2D>().velocity.y > 4f)
        {
            limit = GetComponent<Rigidbody2D>().velocity;
            limit.y = 3.95f;
            limit.x = 0f;
            GetComponent<Rigidbody2D>().velocity = limit;
        }
    }

    public void SpeedUp()
    {

        //GetComponent<Rigidbody2D>().velocity += speed;
        GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        GetComponent<Rigidbody2D>().AddForce(speed);

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        health--;
    }
}
