using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class HighScore : MonoBehaviour
{
    float x;
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("HighScoree"))
        {
            PlayerPrefs.SetFloat("HighScoree", 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateHighScore()
    {
         x = FindObjectOfType<Ball>().GetScore();
        //long newHigh = Convert.ToInt64(x);
        PlayerPrefs.SetFloat("HighScoree", x);
        Debug.Log("NEW HIGH SCORE :" + x);
    }

    public float GetScore()
    {
        return x;
    }

}
