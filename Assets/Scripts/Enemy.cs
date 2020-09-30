using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour

{
    [SerializeField]GameController gameController;
    float movementSpeed;
    Vector3 eulerAngle;
    float deg;
    float rad;
    [SerializeField] AudioClip ballSound;
    [SerializeField] ParticleSystem ps;
    AudioSource myAudioSource;
     void Start()
    {
        myAudioSource = GetComponent<AudioSource>();
    }


    public void MakeEnemyRotate()
    {
        
        deg = Random.Range(30, 150);
        
        // direkt ustume gelmesin diye egim yeterli mi diye bakiyor
        while (deg < 110 && deg > 70)
        {
            deg = Random.Range(30, 150);
        }
        //radyana cevirdim euler icin
        rad = deg * Mathf.Deg2Rad;
        transform.eulerAngles = new Vector3(0, 0, deg);
        //calculusten aa alan adama sin cos anlatacak degilim ne haddime -----------> Estağfurullah :D
        eulerAngle = transform.eulerAngles;

        //GetComponent<Rigidbody2D>().velocity = new Vector3(-5,0, 0);

    }
    public void MakeEnemyMove()
    {
        movementSpeed = gameController.GetMovementSpeed();
        movementSpeed = movementSpeed ;
        Vector2 sp= new Vector3(-Mathf.Sin(rad) *movementSpeed*3, Mathf.Cos(rad)*movementSpeed*3 , 0);
        GetComponent<Rigidbody2D>().AddForce(sp);

    }




    public void SoundEffect()
    {
        myAudioSource.PlayOneShot(ballSound);
    }
    public void VideoEffect()
    {
        var exp = Instantiate(ps, transform.position, transform.rotation);
        exp.loop = false;
        exp.Play();
        Destroy(exp.gameObject, exp.duration);
    }
    public float GetDuration()
    {
        return ps.duration;



    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

    }
    void OnTriggerEnter2D(Collider2D col)
    {

        SoundEffect();
        VideoEffect();
        // Destroy(gameObject, 1);

    }


}
