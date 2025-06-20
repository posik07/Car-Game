using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeScript : MonoBehaviour
{
    public void ToUIScene()
    {
        SceneManager.LoadScene("CityScene", LoadSceneMode.Single);
    }

    public void ToMainMenue()
    {
        SceneManager.LoadScene("Menue", LoadSceneMode.Single);
    }
    public void LoadSecondLevel()
    {
        SceneManager.LoadScene("2Level", LoadSceneMode.Single);
    }

    public void Quit()
    {
        Application.Quit();
    }
    public void RestartCityScene()
    {
        SceneManager.LoadScene("CityScene", LoadSceneMode.Single);
    }
    public void RestartCity2Scene()
    {
        SceneManager.LoadScene("2Level", LoadSceneMode.Single);
    }
}
