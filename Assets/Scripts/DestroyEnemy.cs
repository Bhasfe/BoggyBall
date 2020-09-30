using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    [SerializeField] GameController gameController;
    [SerializeField]Enemy enemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        gameController.AddScore();
        FindObjectOfType<Enemy>().SoundEffect();
        FindObjectOfType<Enemy>().VideoEffect();
        //enemy.SoundEffect();
        Destroy(col.gameObject, FindObjectOfType<Enemy>().GetDuration());
          
    }
}
