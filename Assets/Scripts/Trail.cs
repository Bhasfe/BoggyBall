using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trail : MonoBehaviour
{
    //Vector3 back = new Vector2(-5,0);
    //float speed = 1f;
    // Start is called before the first frame update
    Rigidbody2D rb;
    void Start()
    {
        //transform.position=Vector3.MoveTowards(transform.position, target.position, step);
        rb = GetComponent<Rigidbody2D>();
        Destroy(gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    {
         
        rb.AddForce(Vector2.left/10);
    }
}
