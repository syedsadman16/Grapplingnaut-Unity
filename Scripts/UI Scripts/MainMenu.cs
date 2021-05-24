using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public GameObject GameManager;
    public GameObject ScoringSystem; 
    public void PlayGame()
    {
        //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //PlayerPrefs.DeleteAll();
        PlayerPrefs.DeleteKey("score");
        PlayerPrefs.DeleteKey("point");
        SceneManager.LoadScene("SpaceScene");
    }
    public void QuitGame()
    {
        Debug.Log("Game has successfully quit");
        Application.Quit();
    }
    public void RestartGame()
    {

        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        //PlayerPrefs.DeleteAll();
        PlayerPrefs.DeleteKey("score");
        PlayerPrefs.DeleteKey("point");
        SceneManager.LoadScene("SpaceScene");

        //SceneManager.MoveGameObjectToScene(GameManager, SceneManager.GetActiveScene());
        //ceneManager.MoveGameObjectToScene(ScoringSystem, SceneManager.GetActiveScene());

    }
    public void SettingMenu()
    {
        SceneManager.LoadScene("SettingMenu");
    }
}