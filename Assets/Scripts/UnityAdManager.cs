using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.Monetization;

public class UnityAdManager : MonoBehaviour
{
    private string storeId = "3039691";
    private string video_ad = "video";
    private string rewarded_ad = "rewardedVideo";
    public static UnityAdManager instance;
    // Start is called before the first frame update
    private void Awake()
    {
        
        if (instance == null)
        {
            
            instance = this;
            
        }
 
    }
    void Start()
    {
        Monetization.Initialize(storeId, true);
    }

    // Update is called once per frame
    void Update()
    {

    }

     public void ShowAd()
     {

        if (PlayerPrefs.HasKey("AdCount"))
        {
            if (PlayerPrefs.GetInt("AdCount") == 2)
            {
                

                if (Monetization.IsReady(video_ad))
                {
                    ShowAdPlacementContent ad = null;
                    ad = Monetization.GetPlacementContent(video_ad) as ShowAdPlacementContent;

                    if (ad != null)
                    {
                        ad.Show();
                    }
                }
                PlayerPrefs.SetInt("AdCount", 0);
            }
            else { PlayerPrefs.SetInt("AdCount", PlayerPrefs.GetInt("AdCount") + 1); }
        }else
        {
            PlayerPrefs.SetInt("AdCount", 0);
        }
     }

    public void ShowRewardedAd()
    {
        if (Monetization.IsReady(rewarded_ad)) 
        {
            ShowAdPlacementContent ad = null;
            ad = Monetization.GetPlacementContent(rewarded_ad) as ShowAdPlacementContent;

            if (ad != null)
            {
                ad.Show();
            }
        }
    }


}
