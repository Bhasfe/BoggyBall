using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using GooglePlayGames;
using System;

public class LBManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*
    public void Login()
    {
        Social.localUser.Authenticate((bool success) => { });
    }

    public void AddScoreToLeaderboard()
    {
        long x = Convert.ToInt64(FindObjectOfType<HighScore>().GetScore());
        Social.ReportScore(x, "GPGSID", (bool success) => {
            
        });
    }

    public void ShowLeaderboard()
    {
        Social.ShowLeaderboardUI();
        PlayGamesPlatform.Instance.ShowLeaderboardUI(LeaderBoard.leaderboard_best_scores);

    }*/
}
