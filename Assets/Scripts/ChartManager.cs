using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ChartboostSDK;

public class ChartManager : MonoBehaviour
{
    public static ChartManager instance;
    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        
        Chartboost.cacheInterstitial(CBLocation.HomeScreen);
        Chartboost.setAutoCacheAds(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowInter()
    {

        Chartboost.cacheInterstitial(CBLocation.HomeScreen);
        Chartboost.setAutoCacheAds(true);

        if (PlayerPrefs.HasKey("AdCount"))
        {
            if (PlayerPrefs.GetInt("AdCount") == 2)
            {


                if (Chartboost.hasInterstitial(CBLocation.HomeScreen))
                {

                    Chartboost.showInterstitial(CBLocation.HomeScreen);
                }
                PlayerPrefs.SetInt("AdCount", 0);
            }
            else { PlayerPrefs.SetInt("AdCount", PlayerPrefs.GetInt("AdCount") + 1); }
        }
        else
        {
            PlayerPrefs.SetInt("AdCount", 0);
        }















        Chartboost.cacheInterstitial(CBLocation.HomeScreen);
        Chartboost.setAutoCacheAds(true);
        
        if (Chartboost.hasInterstitial(CBLocation.HomeScreen))
        {
            Chartboost.showInterstitial(CBLocation.HomeScreen);
        }
        
    }
}
