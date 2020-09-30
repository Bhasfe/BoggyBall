using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{

    public void NextScene()
    {
        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentIndex + 1);
    }

    public void goToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void goToGameScene()
    {
        SceneManager.LoadScene(1);
    }


    // Büyük ihtimalle kullanmayız ama yine de ekledim böyle bir fonksiyon
    public void Exit()
    {
        Application.Quit();
    }
}
